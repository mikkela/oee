using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE.Repository
{
    public class ProductionQuery : ValueObject
    {
        private Pair<DateTime, DateTime> dateRange;
        private List<ProductionTeam> teams = new List<ProductionTeam>();
        private OrderNumber order;
        private List<string> machines = new List<string>();
        private ProductNumber product;

        public ProductionQuery()
        {

        }

        public Pair<DateTime, DateTime> DateRange
        {
            get { return dateRange; }
        }

        public IEnumerable<string> Machines
        {
            get { return machines; }
        }

        public ProductNumber Product
        {
            get { return product; }
        }

        public OrderNumber Order
        {
            get { return order; }
        }

        public IEnumerable<ProductionTeam> Teams
        {
            get { return teams; }
        }

        public ProductionQuery AddDateRange(DateTime start, DateTime end)
        {
            ProductionQuery result = (ProductionQuery)this.MemberwiseClone();

            result.dateRange = new Pair<DateTime, DateTime>(new DateTime(start.Year, start.Month, start.Day, 0, 0, 0), new DateTime(end.Year, end.Month, end.Day, 23, 59, 59));

            return result;
        }

        public ProductionQuery AddMachine(string machine)
        {
            ProductionQuery result = (ProductionQuery)this.MemberwiseClone();

            result.machines.Add(machine);

            return result;
        }

        public ProductionQuery AddProduct(ProductNumber product)
        {
            ProductionQuery result = (ProductionQuery)this.MemberwiseClone();

            result.product = product;

            return result;
        }

        public ProductionQuery AddOrder(OrderNumber order)
        {
            ProductionQuery result = (ProductionQuery)this.MemberwiseClone();

            result.order = order;

            return result;
        }

        public ProductionQuery AddTeam(ProductionTeam team)
        {
            ProductionQuery result = (ProductionQuery) this.MemberwiseClone();

            result.teams.Add(team);

            return result;
        }
    }
}
