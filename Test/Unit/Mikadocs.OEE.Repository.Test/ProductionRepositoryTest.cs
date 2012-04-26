using System;
using System.Text;
using System.Collections.Generic;

using NUnit.Framework;

namespace Mikadocs.OEE.Repository.Test
{
    /// <summary>
    /// Summary description for ProductionRepositoryTest
    /// </summary>
    [TestFixture]
    public class ProductionRepositoryTest
    {
        private ProductNumber product1;
        private ProductNumber product2;

        private OrderNumber order1;
        private OrderNumber order2;

        private ProductionTeam team1;
        private ProductionTeam team2;

        private RepositoryFactory factory;
        public ProductionRepositoryTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }        

        [SetUp()]
        public void SetUp()
        {
            factory = new RepositoryFactory();;

            product1 = new ProductNumber("Product A");
            product2 = new ProductNumber("Product B");

            order1 = new OrderNumber("Order A");
            order2 = new OrderNumber("Order B");

            team1 = new ProductionTeam("Daghold");
            team2 = new ProductionTeam("Nathold");

            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                repository.Save(team1);
                repository.Save(team2);
            }
        }        

        [Test]
        public void AddNewProduction()
        {
            Production production = new Production("Machine A", product1, order1, 1000, 100);

            Assert.AreEqual(0, production.Id);
            Assert.AreEqual(0, production.Version);

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                repository.Save(production);
            }

            Assert.AreNotEqual(0, production.Id);
            Assert.AreNotEqual(0, production.Version);
        }

        [Test]
        public void AddNewProductions()
        {
            Production production1 = new Production("Machine A", product1, order1, 1000, 100);
            Production production2 = new Production("Machine A", product1, order2, 500, 25);

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                repository.Save(production1);
                repository.Save(production2);
            }

            Assert.AreNotEqual(production1.Id, production2.Id);
        }

        [Test]
        public void DeleteProductions()
        {
            Production production1 = new Production("Machine A", product1, order1, 1000, 100);
            Production production2 = new Production("Machine A", product1, order2, 500, 25);

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                repository.Save(production1);
                repository.Save(production2);
            }

            List<Production> list = null;
            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                list = new List<Production>(repository.LoadAll());
            }
            CollectionAssert.AreEquivalent(new Production[] { production1, production2 }, list);

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                repository.Delete(production2);
            }
            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                list = new List<Production>(repository.LoadAll());
            }
            CollectionAssert.AreEquivalent(new Production[] { production1 }, list);

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                repository.Delete(production1);                
            }
            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                list = new List<Production>(repository.LoadAll());
            }
            CollectionAssert.AreEquivalent(new Production[] { }, list);

        }

        [Test]
        public void LoadProduction()
        {
            Production production1 = new Production("Machine A", product1, order1, 1000, 100);
            Production production2 = new Production("Machine B", product2, order2, 500, 25);

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                repository.Save(production1);
                repository.Save(production2);
            }

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                foreach (Production production in new Production[] { production1, production2 })
                {
                    Production loadedProduction = repository.Load(production.Id);

                    Assert.AreEqual(production, loadedProduction);
                    Assert.AreNotSame(production, loadedProduction);
                    Assert.AreEqual(production.Machine, loadedProduction.Machine);
                    Assert.AreEqual(production.Product, loadedProduction.Product);
                    Assert.AreEqual(production.Order, loadedProduction.Order);
                    Assert.AreEqual(production.ExpectedItems, loadedProduction.ExpectedItems);
                    Assert.AreEqual(production.ProducedItemsPerHour, loadedProduction.ProducedItemsPerHour);
                    CollectionAssert.AreEquivalent(new List<ProductionShift>(production.Shifts), new List<ProductionShift>(loadedProduction.Shifts));
                }
            }
        }

        [Test]
        public void LoadAllProductions()
        {
            Production production1 = new Production("Machine A", product1, order1, 1000, 100);
            Production production2 = new Production("Machine B", product2, order2, 500, 25);

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                CollectionAssert.AreEquivalent(new Production[] { }, new List<Production>(repository.LoadAll()));
            }

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                repository.Save(production1);
                repository.Save(production2);
            }

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                CollectionAssert.AreEquivalent(new Production[] { production1, production2 }, new List<Production>(repository.LoadAll()));
            }
        }

        [Test]
        public void UpdateProduction()
        {
            Production production = new Production("Machine A", product1, order1, 1000, 100);            

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                repository.Save(production);
            }

            production.Product = product2;
            production.Order = order2;
            production.ExpectedItems = 750;
            production.ProducedItemsPerHour = 60;

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                repository.Save(production);
            }

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                Production loadedProduction = repository.Load(production.Id);

                Assert.AreNotSame(production, loadedProduction);
                Assert.AreEqual(production, loadedProduction);
                Assert.AreEqual(production.Machine, loadedProduction.Machine);
                Assert.AreEqual(production.Product, loadedProduction.Product);
                Assert.AreEqual(production.Order, loadedProduction.Order);
                Assert.AreEqual(production.ExpectedItems, loadedProduction.ExpectedItems);
                Assert.AreEqual(production.ProducedItemsPerHour, loadedProduction.ProducedItemsPerHour);
                CollectionAssert.AreEquivalent(new List<ProductionShift>(production.Shifts), new List<ProductionShift>(loadedProduction.Shifts));
            }
        }
        [Test]
        public void UpdateProductionShifts()
        {
            Production production = new Production("Machine A", product1, order1, 1000, 100);

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                repository.Save(production);
            }

            ProductionShift shift1 = production.AddProductionShift(team1, new DateTime(2008, 11, 12));
            ProductionShift shift2 = production.AddProductionShift(team2, new DateTime(2008, 11, 12));

            using (IEntityRepository<ProductionShift> repository = factory.CreateEntityRepository<ProductionShift>())
            {
                repository.Save(shift1);
                repository.Save(shift2);
            }

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                repository.Save(production);
            }

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                Production loadedProduction = repository.Load(production.Id);

                Assert.AreNotSame(production, loadedProduction);
                Assert.AreEqual(production, loadedProduction);
                Assert.AreEqual(production.Machine, loadedProduction.Machine);
                Assert.AreEqual(production.Product, loadedProduction.Product);
                Assert.AreEqual(production.Order, loadedProduction.Order);
                Assert.AreEqual(production.ExpectedItems, loadedProduction.ExpectedItems);
                Assert.AreEqual(production.ProducedItemsPerHour, loadedProduction.ProducedItemsPerHour);
                CollectionAssert.AreEquivalent(new List<ProductionShift>(production.Shifts), new List<ProductionShift>(loadedProduction.Shifts));
            }
        }

        [Test]
        public void SaveProductionTwice()
        {
            Production production = new Production("Machine A", product1, order1, 1000, 100);

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                repository.Save(production);
            }

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                repository.Save(production);
            }

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                Production loadedProduction = repository.Load(production.Id);

                Assert.AreEqual(production, loadedProduction);
                Assert.AreEqual(production.Machine, loadedProduction.Machine);
                Assert.AreEqual(production.Product, loadedProduction.Product);
                Assert.AreEqual(production.Order, loadedProduction.Order);
                Assert.AreEqual(production.ExpectedItems, loadedProduction.ExpectedItems);
                Assert.AreEqual(production.ProducedItemsPerHour, loadedProduction.ProducedItemsPerHour);
                CollectionAssert.AreEquivalent(new List<ProductionShift>(production.Shifts), new List<ProductionShift>(loadedProduction.Shifts));
            }
        }

        [ExpectedException(typeof(RepositoryException))]
        [Test]
        public void AddTwoProductionsWithSameOrder()
        {
            Production production1 = new Production("Machine A", product1, order1, 1000, 100);
            Production production2 = new Production("Machine A", product1, order1, 1000, 100);

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                repository.Save(production1);
                repository.Save(production2);
            }
        }
    }
}
