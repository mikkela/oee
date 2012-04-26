using System;
using System.Text;
using System.Collections.Generic;

using NUnit.Framework;

namespace Mikadocs.OEE.Repository.Test
{
    /// <summary>
    /// Summary description for ProductionLegRepositoryTest
    /// </summary>
    [TestFixture]
    public class ProductionShiftRepositoryTest
    {
        private ProductNumber product1;
        private ProductNumber product2;

        private OrderNumber order1;
        private OrderNumber order2;

        private Production production1;
        private Production production2;

        private ProductionTeam team1;
        private ProductionTeam team2;

        private ProductionStop productionStop1;
        private ProductionStop productionStop2;

        private RepositoryFactory factory;

        public ProductionShiftRepositoryTest()
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

            production1 = new Production("Machine A", product1, order1, 1000, 100);
            production2 = new Production("Machine A", product2, order2, 500, 50);

            using (IEntityRepository<Production> repository = factory.CreateEntityRepository<Production>())
            {
                repository.Save(production1);
                repository.Save(production2);
            }

            team1 = new ProductionTeam("Daghold");
            team2 = new ProductionTeam("Nathold");

            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                repository.Save(team1);
                repository.Save(team2);
            }

            productionStop1 = new ProductionStop("Stop A");
            productionStop2 = new ProductionStop("Stop B");

            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                repository.Save(productionStop1);
                repository.Save(productionStop2);
            }
        }        

        [Test]
        public void AddNewProductionShift()
        {
            ProductionShift productionShift = production1.AddProductionShift(team1, new DateTime(2008, 12, 8));

            Assert.AreEqual(0, productionShift.Id);
            Assert.AreEqual(0, productionShift.Version);

            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                repository.Save(productionShift);
            }

            Assert.AreNotEqual(0, productionShift.Id);
            Assert.AreNotEqual(0, productionShift.Version);
        }

        [Test]
        public void AddNewProductionShifts()
        {
            ProductionShift productionShift1 = production1.AddProductionShift(team1, new DateTime(2008, 12, 8));
            
            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                repository.Save(productionShift1);
            }

            ProductionShift productionShift2 = production1.AddProductionShift(team2, new DateTime(2008, 12, 8));

            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                repository.Save(productionShift2);
            }

            ProductionShift productionShift3 = production2.AddProductionShift(team1, new DateTime(2008, 12, 8));

            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                repository.Save(productionShift3);
            }

            Assert.AreNotEqual(productionShift1.Id, productionShift2.Id);
            Assert.AreNotEqual(productionShift1.Id, productionShift3.Id);
            Assert.AreNotEqual(productionShift2.Id, productionShift3.Id);
        }

        [Test]
        public void DeleteProductionShifts()
        {
            ProductionShift productionShift1 = production1.AddProductionShift(team1, new DateTime(2008, 12, 8));

            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                repository.Save(productionShift1);
            }

            ProductionShift productionShift2 = production1.AddProductionShift(team2, new DateTime(2008, 12, 8));

            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                repository.Save(productionShift2);
            }

            ProductionShift productionShift3 = production2.AddProductionShift(team1, new DateTime(2008, 12, 8));

            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                repository.Save(productionShift3);
            }
            List<ProductionShift> list = null;
            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                list = new List<ProductionShift>(repository.LoadAll());
            }
            CollectionAssert.AreEquivalent(new [] { productionShift1, productionShift2, productionShift3 }, list);
            
            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                repository.Delete(productionShift2);                
            }
            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                list = new List<ProductionShift>(repository.LoadAll());
            }
            CollectionAssert.AreEquivalent(new [] { productionShift1, productionShift3 }, list);

            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                repository.Delete(productionShift1);
                repository.Delete(productionShift3);
            }
            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                list = new List<ProductionShift>(repository.LoadAll());
            }
            CollectionAssert.AreEquivalent(new ProductionShift[] { }, list);
            
        }

        [Test]
        public void LoadProductionShift()
        {
            ProductionShift productionShift1 = production1.AddProductionShift(team1, new DateTime(2008, 12, 8));

            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                repository.Save(productionShift1);
            }

            ProductionShift productionShift2 = production1.AddProductionShift(team2, new DateTime(2008, 12, 8));

            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                repository.Save(productionShift2);
            }

            ProductionShift productionShift3 = production2.AddProductionShift(team1, new DateTime(2008, 12, 8));

            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                repository.Save(productionShift3);
            }

            using (IEntityRepository<ProductionShift> repository = factory.CreateEntityRepository<ProductionShift>())
            {
                foreach (var shift in new [] { productionShift1, productionShift2, productionShift3 })
                {
                    ProductionShift loadedShift = repository.Load(shift.Id);

                    Assert.AreNotSame(shift, loadedShift);
                    Assert.AreEqual(shift, loadedShift);
                    Assert.AreEqual(shift.DiscardedItems, loadedShift.DiscardedItems);
                    Assert.AreEqual(shift.Duration, loadedShift.Duration);
                    Assert.AreEqual(shift.Order, loadedShift.Order);
                    Assert.AreEqual(shift.Product, loadedShift.Product);
                    Assert.AreEqual(shift.Production, loadedShift.Production);
                    Assert.AreEqual(shift.ProductionStart, loadedShift.ProductionStart);
                    Assert.AreEqual(shift.ProductionEnd, loadedShift.ProductionEnd);
                    CollectionAssert.AreEquivalent(new List<ProductionStopRegistration>(shift.ProductionStopRegistrations), new List<ProductionStopRegistration>(loadedShift.ProductionStopRegistrations));
                    Assert.AreEqual(shift.Team, loadedShift.Team);
                }
            }
        }
/*
        [Test]
        public void LoadAllProductionLegs()
        {
            ProductionShift productionShift1 = production1.AddProductionShift(team1, new DateTime(2008, 12, 8));
            ProductionShift productionShift2 = production1.AddProductionShift(team2, new DateTime(2008, 12, 8));
            ProductionShift productionShift3 = production2.AddProductionShift(team1, new DateTime(2008, 12, 8));

            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                CollectionAssert.AreEquivalent(new ProductionShift[] { }, new List<ProductionShift>(repository.LoadAll()));
            }

            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                repository.Save(productionShift1);
                repository.Save(productionShift2);
                repository.Save(productionShift3);
            }            

            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                CollectionAssert.AreEquivalent(new [] { productionShift1, productionShift2, productionShift3 }, new List<ProductionShift>(repository.LoadAll()));
            }
        }
        */
        //[Test]
        //public void LoadProductionLeg()
        //{
        //    ProductionLeg productionLeg1 = production1.AddProductionLeg(team1, new DateTime(2008, 12, 8, 6, 30, 0), 0);
        //    ProductionLeg productionLeg2 = production1.AddProductionLeg(team2, new DateTime(2008, 12, 8, 14, 15, 0), 0);
        //    ProductionLeg productionLeg3 = production2.AddProductionLeg(team1, new DateTime(2008, 12, 8, 6, 30, 0), 0);

        //    using (IEntityRepository<ProductionLeg> repository = factory.CreateEntityRepository<ProductionLeg>())
        //    {
        //        repository.Save(productionLeg1);
        //        repository.Save(productionLeg2);
        //        repository.Save(productionLeg3);
        //    }

        //    using (IEntityRepository<ProductionLeg> repository = factory.CreateEntityRepository<ProductionLeg>())
        //    {
        //        foreach (ProductionLeg productionLeg in new ProductionLeg[] { productionLeg1, productionLeg2, productionLeg3 })
        //        {
        //            ProductionLeg loadedProductionLeg = repository.Load(productionLeg.Id);

        //            Assert.AreNotSame(productionLeg, loadedProductionLeg);
        //            Assert.AreEqual(productionLeg, loadedProductionLeg);
        //            Assert.AreEqual(productionLeg.CounterStart, loadedProductionLeg.CounterStart);
        //            Assert.AreEqual(productionLeg.CounterEnd, loadedProductionLeg.CounterEnd);
        //            Assert.AreEqual(productionLeg.DiscardedItems, loadedProductionLeg.DiscardedItems);
        //            Assert.AreEqual(productionLeg.Duration, loadedProductionLeg.Duration);
        //            Assert.AreEqual(productionLeg.Order, loadedProductionLeg.Order);
        //            Assert.AreEqual(productionLeg.Product, loadedProductionLeg.Product);
        //            Assert.AreEqual(productionLeg.Production, loadedProductionLeg.Production);
        //            Assert.AreEqual(productionLeg.ProductionStart, loadedProductionLeg.ProductionStart);
        //            Assert.AreEqual(productionLeg.ProductionEnd, loadedProductionLeg.ProductionEnd);
        //            CollectionAssert.AreEquivalent(new List<ProductionStopRegistration>(productionLeg.ProductionStopRegistrations), new List<ProductionStopRegistration>(loadedProductionLeg.ProductionStopRegistrations));
        //            Assert.AreEqual(productionLeg.Team, loadedProductionLeg.Team);
        //        }
        //    }
        //}

        //[Test]
        //public void UpdateProductionLegStatistics()
        //{
        //    ProductionLeg productionLeg = production1.AddProductionLeg(team1, new DateTime(2008, 12, 8, 6, 30, 0), 0);

        //    using (IEntityRepository<ProductionLeg> repository = factory.CreateEntityRepository<ProductionLeg>())
        //    {
        //        repository.Save(productionLeg);
        //    }

        //    productionLeg.UpdateStatistics(productionLeg.ProductionStart.AddHours(1), 90, 10);
            
        //    using (IEntityRepository<ProductionLeg> repository = factory.CreateEntityRepository<ProductionLeg>())
        //    {
        //        repository.Save(productionLeg);
        //    }

        //    using (IEntityRepository<ProductionLeg> repository = factory.CreateEntityRepository<ProductionLeg>())
        //    {
        //        ProductionLeg loadedProductionLeg = repository.Load(productionLeg.Id);

        //        Assert.AreNotSame(productionLeg, loadedProductionLeg);
        //        Assert.AreEqual(productionLeg, loadedProductionLeg);
        //        Assert.AreEqual(productionLeg.CounterStart, loadedProductionLeg.CounterStart);
        //        Assert.AreEqual(productionLeg.CounterEnd, loadedProductionLeg.CounterEnd);
        //        Assert.AreEqual(productionLeg.DiscardedItems, loadedProductionLeg.DiscardedItems);
        //        Assert.AreEqual(productionLeg.Duration, loadedProductionLeg.Duration);
        //        Assert.AreEqual(productionLeg.Order, loadedProductionLeg.Order);
        //        Assert.AreEqual(productionLeg.Product, loadedProductionLeg.Product);
        //        Assert.AreEqual(productionLeg.Production, loadedProductionLeg.Production);
        //        Assert.AreEqual(productionLeg.ProductionStart, loadedProductionLeg.ProductionStart);
        //        Assert.AreEqual(productionLeg.ProductionEnd, loadedProductionLeg.ProductionEnd);
        //        CollectionAssert.AreEquivalent(new List<ProductionStopRegistration>(productionLeg.ProductionStopRegistrations), new List<ProductionStopRegistration>(loadedProductionLeg.ProductionStopRegistrations));
        //        Assert.AreEqual(productionLeg.Team, loadedProductionLeg.Team);
        //    }
        //}

        //[Test]
        //public void UpdateProductionLegStopRegistrations()
        //{
        //    ProductionLeg productionLeg = production1.AddProductionLeg(team1, new DateTime(2008, 12, 8, 6, 30, 0), 0);

        //    using (IEntityRepository<ProductionLeg> repository = factory.CreateEntityRepository<ProductionLeg>())
        //    {
        //        repository.Save(productionLeg);
        //    }

        //    productionLeg.AddProductionStopRegistration(new ProductionStopRegistration(productionStop1, new TimeSpan(0, 10, 0)));
        //    productionLeg.AddProductionStopRegistration(new ProductionStopRegistration(productionStop2, new TimeSpan(0, 15, 0)));
        //    productionLeg.AddProductionStopRegistration(new ProductionStopRegistration(productionStop1, new TimeSpan(0, 7, 0)));

        //    using (IEntityRepository<ProductionLeg> repository = factory.CreateEntityRepository<ProductionLeg>())
        //    {
        //        repository.Save(productionLeg);
        //    }

        //    using (IEntityRepository<ProductionLeg> repository = factory.CreateEntityRepository<ProductionLeg>())
        //    {
        //        ProductionLeg loadedProductionLeg = repository.Load(productionLeg.Id);

        //        Assert.AreNotSame(productionLeg, loadedProductionLeg);
        //        Assert.AreEqual(productionLeg, loadedProductionLeg);
        //        Assert.AreEqual(productionLeg.CounterStart, loadedProductionLeg.CounterStart);
        //        Assert.AreEqual(productionLeg.CounterEnd, loadedProductionLeg.CounterEnd);
        //        Assert.AreEqual(productionLeg.DiscardedItems, loadedProductionLeg.DiscardedItems);
        //        Assert.AreEqual(productionLeg.Duration, loadedProductionLeg.Duration);
        //        Assert.AreEqual(productionLeg.Order, loadedProductionLeg.Order);
        //        Assert.AreEqual(productionLeg.Product, loadedProductionLeg.Product);
        //        Assert.AreEqual(productionLeg.Production, loadedProductionLeg.Production);
        //        Assert.AreEqual(productionLeg.ProductionStart, loadedProductionLeg.ProductionStart);
        //        Assert.AreEqual(productionLeg.ProductionEnd, loadedProductionLeg.ProductionEnd);
        //        CollectionAssert.AreEquivalent(new List<ProductionStopRegistration>(productionLeg.ProductionStopRegistrations), new List<ProductionStopRegistration>(loadedProductionLeg.ProductionStopRegistrations));
        //        Assert.AreEqual(productionLeg.Team, loadedProductionLeg.Team);
        //    }
        //}

        [Test]
        public void SaveProductionShiftTwice()
        {
            ProductionShift shift = production1.AddProductionShift(team1, new DateTime(2008, 12, 8));

            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                repository.Save(shift);
            }

            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                repository.Save(shift);
            }

            using (var repository = factory.CreateEntityRepository<ProductionShift>())
            {
                ProductionShift loadedShift = repository.Load(shift.Id);

                Assert.AreNotSame(shift, loadedShift);
                Assert.AreEqual(shift, loadedShift);
                Assert.AreEqual(shift.DiscardedItems, loadedShift.DiscardedItems);
                Assert.AreEqual(shift.Duration, loadedShift.Duration);
                Assert.AreEqual(shift.Order, loadedShift.Order);
                Assert.AreEqual(shift.Product, loadedShift.Product);
                Assert.AreEqual(shift.Production, loadedShift.Production);
                Assert.AreEqual(shift.ProductionStart, loadedShift.ProductionStart);
                Assert.AreEqual(shift.ProductionEnd, loadedShift.ProductionEnd);
                CollectionAssert.AreEquivalent(new List<ProductionStopRegistration>(shift.ProductionStopRegistrations), new List<ProductionStopRegistration>(loadedShift.ProductionStopRegistrations));
                Assert.AreEqual(shift.Team, loadedShift.Team);
            }
        }

        //[Test]
        //public void SaveProductionLegTwice()
        //{
        //    ProductionLeg productionLeg = production1.AddProductionLeg(team1, new DateTime(2008, 12, 8, 6, 30, 0), 0);

        //    using (IEntityRepository<ProductionLeg> repository = factory.CreateEntityRepository<ProductionLeg>())
        //    {
        //        repository.Save(productionLeg);
        //    }

        //    using (IEntityRepository<ProductionLeg> repository = factory.CreateEntityRepository<ProductionLeg>())
        //    {
        //        repository.Save(productionLeg);
        //    }

        //    using (IEntityRepository<ProductionLeg> repository = factory.CreateEntityRepository<ProductionLeg>())
        //    {
        //        ProductionLeg loadedProductionLeg = repository.Load(productionLeg.Id);

        //        Assert.AreNotSame(productionLeg, loadedProductionLeg);
        //        Assert.AreEqual(productionLeg, loadedProductionLeg);
        //        Assert.AreEqual(productionLeg.CounterStart, loadedProductionLeg.CounterStart);
        //        Assert.AreEqual(productionLeg.CounterEnd, loadedProductionLeg.CounterEnd);
        //        Assert.AreEqual(productionLeg.DiscardedItems, loadedProductionLeg.DiscardedItems);
        //        Assert.AreEqual(productionLeg.Duration, loadedProductionLeg.Duration);
        //        Assert.AreEqual(productionLeg.Order, loadedProductionLeg.Order);
        //        Assert.AreEqual(productionLeg.Product, loadedProductionLeg.Product);
        //        Assert.AreEqual(productionLeg.Production, loadedProductionLeg.Production);
        //        Assert.AreEqual(productionLeg.ProductionStart, loadedProductionLeg.ProductionStart);
        //        Assert.AreEqual(productionLeg.ProductionEnd, loadedProductionLeg.ProductionEnd);
        //        CollectionAssert.AreEquivalent(new List<ProductionStopRegistration>(productionLeg.ProductionStopRegistrations), new List<ProductionStopRegistration>(loadedProductionLeg.ProductionStopRegistrations));
        //        Assert.AreEqual(productionLeg.Team, loadedProductionLeg.Team);
        //    }
        //}        
    }
}
