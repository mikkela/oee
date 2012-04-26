using System;
using System.Text;
using System.Collections.Generic;

using NUnit.Framework;

namespace Mikadocs.OEE.Repository.Test
{
    /// <summary>
    /// Summary description for ProductionStopRepositoryTest
    /// </summary>
    [TestFixture]
    public class ProductionStopRepositoryTest
    {
        public ProductionStopRepositoryTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }        

        [Test]
        public void AddNewProductionStop()
        {
            RepositoryFactory factory = new RepositoryFactory();;
            ProductionStop productionStop = new ProductionStop("Alarm");

            Assert.AreEqual(0, productionStop.Id);
            Assert.AreEqual(0, productionStop.Version);

            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                repository.Save(productionStop);
            }

            Assert.AreNotEqual(0, productionStop.Id);
            Assert.AreNotEqual(0, productionStop.Version);
        }

        [Test]
        public void AddNewProductionStops()
        {
            RepositoryFactory factory = new RepositoryFactory();;
            ProductionStop productionStop1 = new ProductionStop("Alarm");
            ProductionStop productionStop2 = new ProductionStop("Warning");

            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                repository.Save(productionStop1);
                repository.Save(productionStop2);
            }

            Assert.AreNotEqual(productionStop1.Id, productionStop2.Id);
        }

        [Test]
        public void DeleteProductionStops()
        {
            RepositoryFactory factory = new RepositoryFactory(); ;
            ProductionStop productionStop1 = new ProductionStop("Alarm");
            ProductionStop productionStop2 = new ProductionStop("Warning");

            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                repository.Save(productionStop1);
                repository.Save(productionStop2);
            }

            List<ProductionStop> list = null;
            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                list = new List<ProductionStop>(repository.LoadAll());
            }
            CollectionAssert.AreEquivalent(new ProductionStop[] { productionStop1, productionStop2 }, list);

            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                repository.Delete(productionStop2);
            }
            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                list = new List<ProductionStop>(repository.LoadAll());
            }
            CollectionAssert.AreEquivalent(new ProductionStop[] { productionStop1 }, list);

            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                repository.Delete(productionStop1);                
            }
            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                list = new List<ProductionStop>(repository.LoadAll());
            }
            CollectionAssert.AreEquivalent(new ProductionStop[] { }, list);

        }

        [Test]
        public void LoadProductionStop()
        {
            RepositoryFactory factory = new RepositoryFactory();;
            ProductionStop productionStop1 = new ProductionStop("Alarm", true);
            ProductionStop productionStop2 = new ProductionStop("Warning", false);

            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                repository.Save(productionStop1);
                repository.Save(productionStop2);
            }

            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                foreach (ProductionStop productionStop in new ProductionStop[] { productionStop1, productionStop2 })
                {
                    ProductionStop loadedProductionStop = repository.Load(productionStop.Id);

                    Assert.AreNotSame(productionStop, loadedProductionStop);
                    Assert.AreEqual(productionStop, loadedProductionStop);
                    Assert.AreEqual(productionStop.GlobalId, loadedProductionStop.GlobalId);
                    Assert.AreEqual(productionStop.Name, loadedProductionStop.Name);
                    Assert.AreEqual(productionStop.Planned, loadedProductionStop.Planned);
                }
            }
        }

        [Test]
        public void LoadAllProductionStops()
        {
            RepositoryFactory factory = new RepositoryFactory();;
            ProductionStop productionStop1 = new ProductionStop("Alarm", true);
            ProductionStop productionStop2 = new ProductionStop("Warning", false);

            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                CollectionAssert.AreEquivalent(new ProductionStop[] { }, new List<ProductionStop>(repository.LoadAll()));
            }

            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                repository.Save(productionStop1);
                repository.Save(productionStop2);
            }

            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                CollectionAssert.AreEquivalent(new ProductionStop[] { productionStop1, productionStop2 }, new List<ProductionStop>(repository.LoadAll()));
            }
        }

        [Test]
        public void UpdateProductionStop()
        {
            RepositoryFactory factory = new RepositoryFactory();;
            ProductionStop productionStop = new ProductionStop("Alarm", true);

            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                repository.Save(productionStop);
            }

            productionStop.Name = "Warning";
            productionStop.Planned = false;

            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                repository.Save(productionStop);
            }

            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                ProductionStop loadedProductionStop = repository.Load(productionStop.Id);

                Assert.AreNotSame(productionStop, loadedProductionStop);                    
                Assert.AreEqual(productionStop, loadedProductionStop);
                Assert.AreEqual(productionStop.GlobalId, loadedProductionStop.GlobalId);
                Assert.AreEqual(productionStop.Name, loadedProductionStop.Name);
                Assert.AreEqual(productionStop.Planned, loadedProductionStop.Planned);
            }
        }

        [Test]
        public void SaveProductionStopTwice()
        {
            RepositoryFactory factory = new RepositoryFactory();;
            ProductionStop productionStop = new ProductionStop("Alarm", true);

            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                repository.Save(productionStop);
            }

            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                repository.Save(productionStop);
            }

            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                ProductionStop loadedProductionStop = repository.Load(productionStop.Id);

                Assert.AreNotSame(productionStop, loadedProductionStop);                    
                Assert.AreEqual(productionStop, loadedProductionStop);
                Assert.AreEqual(productionStop.GlobalId, loadedProductionStop.GlobalId);
                Assert.AreEqual(productionStop.Name, loadedProductionStop.Name);
                Assert.AreEqual(productionStop.Planned, loadedProductionStop.Planned);
            }
        }

        [ExpectedException(typeof(RepositoryException))]
        [Test]
        public void AddTwoProductionStopsWithSameProductionStopName()
        {
            RepositoryFactory factory = new RepositoryFactory();;
            ProductionStop productionStop1 = new ProductionStop("Alarm", true);
            ProductionStop productionStop2 = new ProductionStop("Alarm", false);

            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                repository.Save(productionStop1);
                repository.Save(productionStop2);
            }
        }
    }
}
