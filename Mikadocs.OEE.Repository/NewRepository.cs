using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using NHibernate.Criterion;

namespace Mikadocs.OEE.Repository
{
    public class NewRepository : IDisposable, IProductionQueryRepository
    {
        private readonly ISession _session;
        private ITransaction transaction;
        private ProductionQueryRepository productionQueryRepository;
        public NewRepository()
        {
            _session = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory().OpenSession();
            productionQueryRepository = new ProductionQueryRepository(_session);
        }

        public void BeginTransaction()
        {
            transaction = _session.BeginTransaction();
        }

        public void Save<TObject>(IEnumerable<TObject> objects)
        {
            try
            {
                foreach (var o in objects)
                {
                    _session.SaveOrUpdate(o);
                }
            }
            catch (HibernateException e)
            {
                transaction.Rollback();
                _session.Clear();
                throw new RepositoryException("Could not save the entity due to an internal exception", e);
            }
        }

        public void Delete(object entity)
        {
            try
            {
                _session.Delete(entity);
            }
            catch (HibernateException e)
            {
                transaction.Rollback();
                _session.Clear();
                throw new RepositoryException("Could not delete the entity due to an internal exception", e);
            }
        }

        public IEnumerable<TEntity> LoadAll<TEntity>()
        {
            IList<TEntity> result;

            try
            {
                ICriteria criteria = _session.CreateCriteria(typeof(TEntity));
                criteria.SetMaxResults(50);
                criteria.AddOrder(new NHibernate.Criterion.Order("Id", false));

                result = criteria.List<TEntity>();
            }
            catch (HibernateException e)
            {
                result = new List<TEntity>();               
            }

            return result;
        }

        public void Commit()
        {
            transaction.Commit();
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (transaction != null)
                transaction.Dispose();
            _session.Dispose();
        }

        #endregion

        public IEnumerable<Production> LoadProductions(ProductionQuery query)
        {
            IList<Production> result = new List<Production>();

            try
            {
                ICriteria criteria = _session.CreateCriteria(typeof(Production));

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
            return LoadProduction(orderNumber);
        }
    }
}
