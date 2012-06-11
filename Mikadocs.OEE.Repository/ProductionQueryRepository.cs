using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Criterion;

namespace Mikadocs.OEE.Repository
{
    class ProductionQueryRepository : IProductionQueryRepository
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly ISession _session;
        private readonly bool _doDuplicatew;

        public ProductionQueryRepository(ISession session, bool doDuplicatew)
        {
            _session = session;
            _doDuplicatew = doDuplicatew;
        }

        #region IProductionQueryRepository Members

        public IEnumerable<Production> LoadProductions(ProductionQuery query)
        {
            IList<Production> result = new List<Production>();

            try
            {
                ICriteria criteria = _session.CreateCriteria(typeof(Production));

                var machines = new List<string>(query.Machines);
                var teams = new List<ProductionTeam>(query.Teams);


                if (machines.Count > 0)
                {
                    criteria.Add(Restrictions.In("Machine", machines));
                }

                if (query.Order != null)
                    criteria.Add(Restrictions.Eq("Order", query.Order));

                if (query.Product != null)
                    criteria.Add(Restrictions.Eq("Product", query.Product));

                foreach (var p in criteria.List<Production>())
                {
                    var production = p;

                    if (query.DateRange != null)
                    {
                        if (production.ProductionEnd.Date < query.DateRange.First.Date ||
                            query.DateRange.Second.Date < production.ProductionStart.Date)
                            continue;


                        var shifts = production.Shifts.Where(shift => query.DateRange.First <= shift.ProductionStart.Date && shift.ProductionStart.Date <= query.DateRange.Second).ToList();

                        if (shifts.Count == 0)
                            continue;
                        if (_doDuplicatew)
                            production = Duplicate(production, shifts);
                        
                    }

                    if (teams.Count > 0)
                    {
                        List<ProductionShift> shifts =
                            new List<ProductionShift>(production.Shifts).FindAll(
                                shift => Enumerable.Contains(teams, shift.Team));

                        if (shifts.Count == 0)
                            continue;

                        if (_doDuplicatew)
                            production = Duplicate(production, shifts);
                    }
                    result.Add(production);
                }
            }
            catch (HibernateException e)
            {
                throw new RepositoryException("Could not load all productions due to an internal exception", e);
            }

            return result;
        }

        public Production LoadProduction(OrderNumber orderNumber)
        {
            try
            {
                ICriteria criteria = _session.CreateCriteria(typeof(Production));

                criteria.Add(Restrictions.Eq("Order", orderNumber));

                return criteria.UniqueResult<Production>();
            }
            catch (HibernateException e)
            {
                Log.Error(string.Format("An exception occurred while loading all production with order number: {0}. No entities were loaded.", orderNumber), e);
                throw new RepositoryException("Could not load production due to an internal exception", e);
            }            
        }

        #endregion        

        private static Production Duplicate(Production p, IEnumerable<ProductionShift> shifts)
        {
            var production = new Production(p.Machine, p.Product, p.Order,
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
