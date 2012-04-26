using System;
using System.Text;
using System.Collections.Generic;

using NUnit.Framework;

namespace Mikadocs.OEE.Repository.Test
{
    /// <summary>
    /// Summary description for ProductionTeamRepositoryTest
    /// </summary>
    [TestFixture]
    public class ProductionTeamRepositoryTest
    {
        public ProductionTeamRepositoryTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }        

        [Test]
        public void AddNewProductionTeam()
        {
            RepositoryFactory factory = new RepositoryFactory();
            ProductionTeam productionTeam = new ProductionTeam("Team A");

            Assert.AreEqual(0, productionTeam.Id);
            Assert.AreEqual(0, productionTeam.Version);

            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                repository.Save(productionTeam);
            }

            Assert.AreNotEqual(0, productionTeam.Id);
            Assert.AreNotEqual(0, productionTeam.Version);
        }

        [Test]
        public void AddNewProductionTeams()
        {
            RepositoryFactory factory = new RepositoryFactory();
            ProductionTeam productionTeam1 = new ProductionTeam("Team A");
            ProductionTeam productionTeam2 = new ProductionTeam("Team B");

            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                repository.Save(productionTeam1);
                repository.Save(productionTeam2);
            }

            Assert.AreNotEqual(productionTeam1.Id, productionTeam2.Id);            
        }

        [Test]
        public void DeleteProductionTeams()
        {
            RepositoryFactory factory = new RepositoryFactory();
            ProductionTeam productionTeam1 = new ProductionTeam("Team A");
            ProductionTeam productionTeam2 = new ProductionTeam("Team B");

            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                repository.Save(productionTeam1);
                repository.Save(productionTeam2);
            }

            List<ProductionTeam> list = null;
            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                list = new List<ProductionTeam>(repository.LoadAll());
            }
            CollectionAssert.AreEquivalent(new ProductionTeam[] { productionTeam1, productionTeam2 }, list);

            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                repository.Delete(productionTeam2);
            }
            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                list = new List<ProductionTeam>(repository.LoadAll());
            }
            CollectionAssert.AreEquivalent(new ProductionTeam[] { productionTeam1 }, list);

            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                repository.Delete(productionTeam1);
            }
            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                list = new List<ProductionTeam>(repository.LoadAll());
            }
            CollectionAssert.AreEquivalent(new ProductionTeam[] { }, list);
        }

        [Test]
        public void LoadProductionTeam()
        {
            RepositoryFactory factory = new RepositoryFactory();
            ProductionTeam productionTeam1 = new ProductionTeam("Team A");
            ProductionTeam productionTeam2 = new ProductionTeam("Team B");

            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                repository.Save(productionTeam1);
                repository.Save(productionTeam2);
            }

            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                foreach (ProductionTeam productionTeam in new ProductionTeam[] { productionTeam1, productionTeam2 })
                {
                    ProductionTeam loadedProductionTeam = repository.Load(productionTeam.Id);

                    Assert.AreEqual(productionTeam, loadedProductionTeam);
                    Assert.AreNotSame(productionTeam, loadedProductionTeam);
                    Assert.AreEqual(productionTeam.GlobalId, loadedProductionTeam.GlobalId);
                    Assert.AreEqual(productionTeam.Name, loadedProductionTeam.Name);                    
                }
            }
        }

        [Test]
        public void LoadAllProductionTeams()
        {
            RepositoryFactory factory = new RepositoryFactory();
            ProductionTeam productionTeam1 = new ProductionTeam("Team A");
            ProductionTeam productionTeam2 = new ProductionTeam("Team B");

            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                CollectionAssert.AreEquivalent(new ProductionTeam[] { }, new List<ProductionTeam>(repository.LoadAll()));
            }

            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                repository.Save(productionTeam1);
                repository.Save(productionTeam2);
            }

            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                CollectionAssert.AreEquivalent(new ProductionTeam[] { productionTeam1, productionTeam2 }, new List<ProductionTeam>(repository.LoadAll()));
            }
        }

        [Test]
        public void UpdateProductionTeam()
        {
            RepositoryFactory factory = new RepositoryFactory();;
            ProductionTeam productionTeam = new ProductionTeam("Team A");

            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                repository.Save(productionTeam);
            }

            productionTeam.Name = "Team B";
            
            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                repository.Save(productionTeam);
            }

            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                ProductionTeam loadedProductionTeam = repository.Load(productionTeam.Id);

                Assert.AreEqual(productionTeam, loadedProductionTeam);
                Assert.AreNotSame(productionTeam, loadedProductionTeam);
                Assert.AreEqual(productionTeam.Name, loadedProductionTeam.Name);
                Assert.AreEqual(productionTeam.GlobalId, loadedProductionTeam.GlobalId);
            }
        }

        [Test]
        public void SaveProductionTeamTwice()
        {
            RepositoryFactory factory = new RepositoryFactory();;
            ProductionTeam productionTeam = new ProductionTeam("Team A");

            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                repository.Save(productionTeam);
            }

            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                repository.Save(productionTeam);
            }

            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                ProductionTeam loadedProductionTeam = repository.Load(productionTeam.Id);

                Assert.AreEqual(productionTeam, loadedProductionTeam);
                Assert.AreNotSame(productionTeam, loadedProductionTeam);
                Assert.AreEqual(productionTeam.Name, loadedProductionTeam.Name);                
            }
        }

        [ExpectedException(typeof(RepositoryException))]
        [Test]
        public void AddTwoProductionTeamsWithSameProductionTeamName()
        {
            RepositoryFactory factory = new RepositoryFactory();;
            ProductionTeam productionTeam1 = new ProductionTeam("Team A");
            ProductionTeam productionTeam2 = new ProductionTeam("Team A");

            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                repository.Save(productionTeam1);
                repository.Save(productionTeam2);
            }
        }        
    }
}
