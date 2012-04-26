using System;
using System.Text;
using System.Collections.Generic;

using NUnit.Framework;

namespace Mikadocs.OEE.Repository.Test
{
    /// <summary>
    /// Summary description for MachineConfigurationRepositoryTest
    /// </summary>
    [TestFixture]
    public class MachineConfigurationRepositoryTest
    {
        private ProductionStop productionStop1;
        private ProductionStop productionStop2;

        private RepositoryFactory factory;

        public MachineConfigurationRepositoryTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }        

        [SetUp()]
        public void SetUp()
        {
            factory = new RepositoryFactory();;

            productionStop1 = new ProductionStop("Stop A");
            productionStop2 = new ProductionStop("Stop B");

            using (IEntityRepository<ProductionStop> repository = factory.CreateEntityRepository<ProductionStop>())
            {
                repository.Save(productionStop1);
                repository.Save(productionStop2);
            }
        }        

        [Test]
        public void AddNewMachineConfiguration()
        {
            MachineConfiguration machineConfiguration = new MachineConfiguration("Machine A", new ProductionStop[] { productionStop1, productionStop2 });

            Assert.AreEqual(0, machineConfiguration.Id);
            Assert.AreEqual(0, machineConfiguration.Version);

            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                repository.Save(machineConfiguration);
            }

            Assert.AreNotEqual(0, machineConfiguration.Id);
            Assert.AreNotEqual(0, machineConfiguration.Version);
        }

        [Test]
        public void AddNewMachineConfigurations()
        {
            MachineConfiguration machineConfiguration1 = new MachineConfiguration("Machine A", new ProductionStop[] { productionStop1, productionStop2 });
            MachineConfiguration machineConfiguration2 = new MachineConfiguration("Machine B", new ProductionStop[] { productionStop1, productionStop2 });
            
            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                repository.Save(machineConfiguration1);
                repository.Save(machineConfiguration2);                
            }

            Assert.AreNotEqual(machineConfiguration1.Id, machineConfiguration2.Id);            
        }

        [Test]
        public void DeleteMachineConfigurations()
        {
            MachineConfiguration machineConfiguration1 = new MachineConfiguration("Machine A", new ProductionStop[] { productionStop1, productionStop2 });
            MachineConfiguration machineConfiguration2 = new MachineConfiguration("Machine B", new ProductionStop[] { productionStop1, productionStop2 });
            
            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                repository.Save(machineConfiguration1);
                repository.Save(machineConfiguration2);                
            }

            List<MachineConfiguration> list = null;
            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                list = new List<MachineConfiguration>(repository.LoadAll());
            }
            CollectionAssert.AreEquivalent(new MachineConfiguration[] { machineConfiguration1, machineConfiguration2 }, list);
            
            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                repository.Delete(machineConfiguration2);                
            }
            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                list = new List<MachineConfiguration>(repository.LoadAll());
            }
            CollectionAssert.AreEquivalent(new MachineConfiguration[] { machineConfiguration1 }, list);

            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                repository.Delete(machineConfiguration1);            
            }
            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                list = new List<MachineConfiguration>(repository.LoadAll());
            }
            CollectionAssert.AreEquivalent(new MachineConfiguration[] { }, list);
            
        }

        [Test]
        public void LoadMachineConfiguration()
        {
            MachineConfiguration machineConfiguration1 = new MachineConfiguration("Machine A", new ProductionStop[] { productionStop1, productionStop2 });
            MachineConfiguration machineConfiguration2 = new MachineConfiguration("Machine B", new ProductionStop[] { productionStop2, productionStop1 });
            
            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                repository.Save(machineConfiguration1);
                repository.Save(machineConfiguration2);                
            }

            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                foreach (MachineConfiguration machineConfiguration in new MachineConfiguration[] { machineConfiguration1, machineConfiguration2 })
                {
                    MachineConfiguration loadedMachineConfiguration = repository.Load(machineConfiguration.Id);

                    Assert.AreNotSame(machineConfiguration, loadedMachineConfiguration);
                    Assert.AreEqual(machineConfiguration, loadedMachineConfiguration);
                    Assert.AreEqual(machineConfiguration.MachineName, loadedMachineConfiguration.MachineName);
                    CollectionAssert.AreEqual(new List<ProductionStop>(machineConfiguration.AvailableProductionStops), new List<ProductionStop>(loadedMachineConfiguration.AvailableProductionStops));                    
                }
            }
        }

        [Test]
        public void LoadAllMachineConfigurations()
        {
            MachineConfiguration machineConfiguration1 = new MachineConfiguration("Machine A", new ProductionStop[] { productionStop1, productionStop2 });
            MachineConfiguration machineConfiguration2 = new MachineConfiguration("Machine B", new ProductionStop[] { productionStop1, productionStop2 });
            
            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                CollectionAssert.AreEquivalent(new MachineConfiguration[] { }, new List<MachineConfiguration>(repository.LoadAll()));
            }

            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                repository.Save(machineConfiguration1);
                repository.Save(machineConfiguration2);                
            }            

            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                CollectionAssert.AreEquivalent(new MachineConfiguration[] { machineConfiguration1, machineConfiguration2 }, new List<MachineConfiguration>(repository.LoadAll()));
            }
        }

        [Test]
        public void UpdateMachineConfiguration()
        {
            MachineConfiguration machineConfiguration = new MachineConfiguration("Machine A", new ProductionStop[] { productionStop1, productionStop2 });

            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                repository.Save(machineConfiguration);
            }

            machineConfiguration.MachineName = "Machine B";
            machineConfiguration.AvailableProductionStops = new ProductionStop[] { productionStop1 };
            
            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                repository.Save(machineConfiguration);
            }

            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                MachineConfiguration loadedMachineConfiguration = repository.Load(machineConfiguration.Id);

                Assert.AreNotSame(machineConfiguration, loadedMachineConfiguration);
                Assert.AreEqual(machineConfiguration, loadedMachineConfiguration);
                Assert.AreEqual(machineConfiguration.MachineName, loadedMachineConfiguration.MachineName);
                CollectionAssert.AreEqual(new List<ProductionStop>(machineConfiguration.AvailableProductionStops), new List<ProductionStop>(loadedMachineConfiguration.AvailableProductionStops));                
            }
        }

        [Test]
        public void SaveMachineConfigurationTwice()
        {
            MachineConfiguration machineConfiguration = new MachineConfiguration("Machine A", new ProductionStop[] { productionStop1, productionStop2 });

            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                repository.Save(machineConfiguration);
            }

            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                repository.Save(machineConfiguration);
            }

            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                MachineConfiguration loadedMachineConfiguration = repository.Load(machineConfiguration.Id);

                Assert.AreNotSame(machineConfiguration, loadedMachineConfiguration);
                Assert.AreEqual(machineConfiguration, loadedMachineConfiguration);
                Assert.AreEqual(machineConfiguration.MachineName, loadedMachineConfiguration.MachineName);
                CollectionAssert.AreEqual(new List<ProductionStop>(machineConfiguration.AvailableProductionStops), new List<ProductionStop>(loadedMachineConfiguration.AvailableProductionStops));                
            }
        }

        [ExpectedException(typeof(RepositoryException))]
        [Test]
        public void AddTwoMachineConfigurationsWithSameMachineName()
        {
            MachineConfiguration machineConfiguration1 = new MachineConfiguration("Machine A", new ProductionStop[] { productionStop1, productionStop2 });
            MachineConfiguration machineConfiguration2 = new MachineConfiguration("Machine A", new ProductionStop[] { productionStop1, productionStop2 });

            using (IEntityRepository<MachineConfiguration> repository = factory.CreateEntityRepository<MachineConfiguration>())
            {
                repository.Save(machineConfiguration1);
                repository.Save(machineConfiguration2);
            }
        }        
    }
}
