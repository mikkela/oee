using System;
using System.Collections.Generic;
using System.Text;

using NHibernate;
using NHibernate.Criterion;

namespace Mikadocs.OEE.Repository
{
    class ProductionQueryRepository : IProductionQueryRepository
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private ISession session;

        public ProductionQueryRepository(ISession session)
        {
            this.session = session;
        }

        #region IProductionQueryRepository Members

        public IEnumerable<Production> LoadProductions(ProductionQuery query)
        {
            //log.InfoFormat("Loading all productions matching: {0}", query);

            IList<Production> result = new List<Production>();

            try
            {
                ICriteria criteria = session.CreateCriteria(typeof(Production));

                List<string> machines = new List<string>(query.Machines);
                List<ProductionTeam> teams = new List<ProductionTeam>(query.Teams);


                if (machines.Count > 0)
                {
                    criteria.Add(Expression.In("Machine", machines));
                }

                if (query.Order != null)
                    criteria.Add(Expression.Eq("Order", query.Order));

                if (query.Product != null)
                    criteria.Add(Expression.Eq("Product", query.Product));

                foreach (Production p in criteria.List<Production>())
                {
                    Production production = p;

                    if (query.DateRange != null)
                    {
                        if (production.ProductionEnd.Date < query.DateRange.First.Date ||
                            query.DateRange.Second.Date < production.ProductionStart.Date)
                            continue;


                        List<ProductionShift> shifts = new List<ProductionShift>();

                        foreach (var shift in production.Shifts)
                        {
                            if (query.DateRange.First <= shift.ProductionStart.Date &&
                                shift.ProductionStart.Date <= query.DateRange.Second)
                                shifts.Add(shift);

                        }
                            
                        if (shifts.Count == 0)
                            continue;
                        production = Duplicate(production, shifts);
                        
                    }

                    if (teams.Count > 0)
                    {
                        List<ProductionShift> shifts =
                            new List<ProductionShift>(production.Shifts).FindAll(delegate(ProductionShift shift)
                                                                                 {
                                                                                     foreach (var team in teams)
                                                                                     {
                                                                                         if (shift.Team.Equals(team))
                                                                                             return true;
                                                                                     }
                                                                                     return false;
                                                                                 });

                        if (shifts.Count == 0)
                            continue;

                        production = Duplicate(production, shifts);
                    }
                    result.Add(production);
                }
            }
            catch (HibernateException e)
            {
                //log.Error(string.Format("An exception occurred while loading all productions matching: {0}. No entities were loaded.", query), e);
                throw new RepositoryException("Could not load all productions due to an internal exception", e);
            }

            //log.InfoFormat("Loaded all productions matching: {0}. {1} entities were found", query, result.Count);
            return result;
        }

        public Production LoadProduction(OrderNumber orderNumber)
        {
            log.InfoFormat("Loading production with order number: {0}", orderNumber);

            Production result = null;

            try
            {
                ICriteria criteria = session.CreateCriteria(typeof(Production));

                criteria.Add(Expression.Eq("Order", orderNumber));

                result = criteria.UniqueResult<Production>();
            }
            catch (HibernateException e)
            {
                log.Error(string.Format("An exception occurred while loading all production with order number: {0}. No entities were loaded.", orderNumber), e);
                throw new RepositoryException("Could not load production due to an internal exception", e);
            }

            log.InfoFormat("Loaded production with order number: {0}. The production were {1}found", orderNumber, (result != null) ? "" : "not ");
            return result;
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {            
        }

        #endregion

        private Production Duplicate(Production p, IEnumerable<ProductionShift> shifts)
        {
            Production production = new Production(p.Machine, p.Product, p.Order,
                                                    p.ExpectedItems,
                                                    p.ProducedItemsPerHour,
                                                    p.ValidatedStartTime);

            foreach (var shift in shifts)
            {
                var s = production.AddProductionShift(shift.Team, shift.ProductionStart.Date);
                foreach (var leg in shift.ProductionLegs)
                {
                    var l = s.AddProductionLeg(leg.ProductionStart, leg.CounterStart);

                    foreach (var registration in shift.ProductionStopRegistrations)
                    {
                        l.AddProductionStopRegistration(registration);
                    }

                    l.UpdateStatistics(leg.ProductionEnd, leg.CounterEnd, leg.DiscardedItems);    
                }


                
            }

            return production;
        }
        
    }
}
