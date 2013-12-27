using System;
using System.Text;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mikadocs.OEE.Test
{
    /// <summary>
    /// Summary description for FactorCalculatorTest
    /// </summary>
    [TestClass]
    public class FactorCalculatorTest
    {
        private class LocalProduction : IProduction
        {
            private TimeSpan duration;
            private IEnumerable<ProductionStopRegistration> registeredProductionStops;
            private long producedItems;
            private long discardedItems;
            private double idealRunRate;

            public LocalProduction(long producedItems, long discardedItems) :
                this(TimeSpan.Zero, new List<ProductionStopRegistration>(), producedItems, discardedItems, 0)
            {

            }
            public LocalProduction(TimeSpan duration, IEnumerable<ProductionStopRegistration> registeredProductionStops) :
                this(duration, registeredProductionStops, 0, 0, 0) 
            { }

            public LocalProduction(TimeSpan duration, IEnumerable<ProductionStopRegistration> registeredProductionStops, long producedItems, double idealRunRate) :
                this(duration, registeredProductionStops, producedItems, 0, idealRunRate) { }

            public LocalProduction(TimeSpan duration, IEnumerable<ProductionStopRegistration> registeredProductionStops, long producedItems, long discardedItems, double idealRunRate)
            {
                this.duration = duration;
                this.registeredProductionStops = registeredProductionStops;
                this.producedItems = producedItems;
                this.discardedItems = discardedItems;
                this.idealRunRate = idealRunRate;
            }
            #region IProduction Members

            public OrderNumber Order
            {
                get { throw new NotImplementedException(); }
            }

            public ProductNumber Product
            {
                get { throw new NotImplementedException(); }
            }

            public DateTime ProductionStart
            {
                get { throw new NotImplementedException(); }
            }

            public TimeSpan Duration
            {
                get { return duration; }
            }

            public IEnumerable<ProductionStopRegistration> ProductionStopRegistrations
            {
                get { return registeredProductionStops; }
            }

            public long ProducedItems
            {
                get { return producedItems; }
            }

            public long DiscardedItems
            {
                get { return discardedItems; }
            }

            public double GetProductionForPeriod(TimeSpan period)
            {
                return idealRunRate;
            }

            #endregion            
                    
        }        

        public FactorCalculatorTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void AvailabilityWithNoProductionStops()
        {
            FactorCalculator calculator = new FactorCalculator(new LocalProduction(new TimeSpan(5, 30, 0), new ProductionStopRegistration[] { }), p => p.Planned);

            Assert.AreEqual<double>(1.0, calculator.Availability);
            Assert.AreEqual<TimeSpan>(new TimeSpan(5, 30, 0), calculator.Duration);
        }

        [TestMethod]
        public void AvailabilityWithSingleProductionStop()
        {
            FactorCalculator calculator = new FactorCalculator(new LocalProduction(new TimeSpan(5, 0, 0), new ProductionStopRegistration[] 
            { 
                new ProductionStopRegistration(new ProductionStop("Test"), new TimeSpan(1, 0, 0)) 
            }), p => p.Planned);

            Assert.AreEqual<double>(0.8, calculator.Availability);
            Assert.AreEqual<TimeSpan>(new TimeSpan(5, 0, 0), calculator.Duration);
        }

        [TestMethod]
        public void AvailabilityWithSinglePlannedProductionStop()
        {
            FactorCalculator calculator = new FactorCalculator(new LocalProduction(new TimeSpan(5, 0, 0), new ProductionStopRegistration[] 
            { 
                new ProductionStopRegistration(new ProductionStop("Test", true), new TimeSpan(1, 0, 0)) 
            }), p => p.Planned);

            Assert.AreEqual<double>(1.0, calculator.Availability);
            Assert.AreEqual<TimeSpan>(new TimeSpan(5, 0, 0), calculator.Duration);
        }

        [TestMethod]
        public void AvailabilityWithMultiplePlannedAndUnplannedProductionStop()
        {
            FactorCalculator calculator = new FactorCalculator(new LocalProduction(new TimeSpan(10, 0, 0), new ProductionStopRegistration[] 
            { 
                new ProductionStopRegistration(new ProductionStop("Test 1"), new TimeSpan(0, 40, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 2", true), new TimeSpan(0, 55, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 3", false), new TimeSpan(1, 0, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 4", true), new TimeSpan(0, 45, 0))
            }), p => p.Planned);

            Assert.AreEqual<double>(0.8, calculator.Availability);
            Assert.AreEqual<TimeSpan>(new TimeSpan(10, 0, 0), calculator.Duration);
        }

        [TestMethod]
        public void AvailabilityWithProductionStopsTakingAllTheTime()
        {
            FactorCalculator calculator = new FactorCalculator(new LocalProduction(new TimeSpan(10, 0, 0), new ProductionStopRegistration[] 
            { 
                new ProductionStopRegistration(new ProductionStop("Test 1"), new TimeSpan(4, 30, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 2", false), new TimeSpan(1, 0, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 3", false), new TimeSpan(0, 30, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 4", false), new TimeSpan(4, 0, 0))
            }), p => p.Planned);

            Assert.AreEqual<double>(0, calculator.Availability);
            Assert.AreEqual<TimeSpan>(new TimeSpan(10, 0, 0), calculator.Duration);
        }

        [TestMethod]
        public void PerformanceWithFullRateAndNoStops()
        {
            FactorCalculator calculator = new FactorCalculator(new LocalProduction(new TimeSpan(5, 30, 0), new ProductionStopRegistration[] { }, 3300, 10), p => p.Planned);

            Assert.AreEqual<double>(1.0, calculator.Performance);
            Assert.AreEqual<TimeSpan>(new TimeSpan(5, 30, 0), calculator.Duration);
        }

        [TestMethod]
        public void PerformanceNotWithFullRateAndNoStops()
        {
            FactorCalculator calculator = new FactorCalculator(new LocalProduction(new TimeSpan(5, 30, 0), new ProductionStopRegistration[] { }, 2640, 10), p => p.Planned);

            Assert.AreEqual<double>(0.8, calculator.Performance);
            Assert.AreEqual<TimeSpan>(new TimeSpan(5, 30, 0), calculator.Duration);
        }

        [TestMethod]
        public void PerformanceWithFullRateAndSomeStops()
        {
            FactorCalculator calculator = new FactorCalculator(new LocalProduction(new TimeSpan(5, 30, 0), new ProductionStopRegistration[] 
            { 
                new ProductionStopRegistration(new ProductionStop("Test 1"), new TimeSpan(0, 30, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 2", true), new TimeSpan(1, 0, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 3", false), new TimeSpan(0, 15, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 4", true), new TimeSpan(0, 5, 0))
            }, 2200, 10), p => p.Planned);

            Assert.AreEqual<double>(1, calculator.Performance);
            Assert.AreEqual<TimeSpan>(new TimeSpan(5, 30, 0), calculator.Duration);
        }

        [TestMethod]
        public void PerformanceNotWithFullRateAndSomeStops()
        {
            FactorCalculator calculator = new FactorCalculator(new LocalProduction(new TimeSpan(5, 30, 0), new ProductionStopRegistration[] 
            { 
                new ProductionStopRegistration(new ProductionStop("Test 1"), new TimeSpan(0, 30, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 2", true), new TimeSpan(1, 0, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 3", false), new TimeSpan(0, 15, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 4", true), new TimeSpan(0, 5, 0))
            }, 1100, 10), p => p.Planned);

            Assert.AreEqual<double>(0.5, calculator.Performance);
            Assert.AreEqual<TimeSpan>(new TimeSpan(5, 30, 0), calculator.Duration);
        }

        [TestMethod]
        public void PerformanceFullZeroRateAndNoStops()
        {
            FactorCalculator calculator = new FactorCalculator(new LocalProduction(new TimeSpan(5, 30, 0), new ProductionStopRegistration[] 
            {                 
            }, 0, 10), p => p.Planned);

            Assert.AreEqual<double>(0, calculator.Performance);
            Assert.AreEqual<TimeSpan>(new TimeSpan(5, 30, 0), calculator.Duration);
        }

        [TestMethod]
        public void PerformanceWithFullRateAndAllStops()
        {
            FactorCalculator calculator = new FactorCalculator(new LocalProduction(new TimeSpan(5, 30, 0), new ProductionStopRegistration[] 
            { 
                new ProductionStopRegistration(new ProductionStop("Test 1"), new TimeSpan(1, 25, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 2", true), new TimeSpan(1, 25, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 3", false), new TimeSpan(1, 20, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 4", true), new TimeSpan(1, 20, 0))
            }, 0, 10), p => p.Planned);

            Assert.AreEqual<double>(0, calculator.Performance);
            Assert.AreEqual<TimeSpan>(new TimeSpan(5, 30, 0), calculator.Duration);
        }

        [TestMethod]
        public void PerformanceWithSomeProducedAndAllStops()
        {
            FactorCalculator calculator = new FactorCalculator(new LocalProduction(new TimeSpan(5, 30, 0), new ProductionStopRegistration[] 
            { 
                new ProductionStopRegistration(new ProductionStop("Test 1"), new TimeSpan(1, 25, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 2", true), new TimeSpan(1, 25, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 3", false), new TimeSpan(1, 20, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 4", true), new TimeSpan(1, 20, 0))
            }, 10, 10), p => p.Planned);

            Assert.AreEqual<double>(0, calculator.Performance);
            Assert.AreEqual<TimeSpan>(new TimeSpan(5, 30, 0), calculator.Duration);
        }

        [TestMethod]
        public void TopQuaility()
        {
            FactorCalculator calculator = new FactorCalculator(new LocalProduction(100, 0), p => p.Planned);

            Assert.AreEqual<double>(1, calculator.Quality);
            Assert.AreEqual<TimeSpan>(new TimeSpan(0, 0, 0), calculator.Duration);
        }

        [TestMethod]
        public void OrdinaryQuaility()
        {
            FactorCalculator calculator = new FactorCalculator(new LocalProduction(100, 25), p => p.Planned);

            Assert.AreEqual<double>(0.75, calculator.Quality);
            Assert.AreEqual<TimeSpan>(new TimeSpan(0, 0, 0), calculator.Duration);
        }

        [TestMethod]
        public void AllFailed()
        {
            FactorCalculator calculator = new FactorCalculator(new LocalProduction(100, 100), p => p.Planned);

            Assert.AreEqual<double>(0, calculator.Quality);
            Assert.AreEqual<TimeSpan>(new TimeSpan(0, 0, 0), calculator.Duration);
        }

        [TestMethod]
        public void ComputeWeightedAverageOverFactorCalculators()
        {
            FactorCalculator calculator1 = new FactorCalculator(new LocalProduction(new TimeSpan(5, 0, 0), new ProductionStopRegistration[] { }), p => p.Planned);
            FactorCalculator calculator2 = new FactorCalculator(new LocalProduction(new TimeSpan(5, 0, 0), new ProductionStopRegistration[] { }), p => p.Planned);
            FactorCalculator calculator3 = new FactorCalculator(new LocalProduction(new TimeSpan(5, 0, 0), new ProductionStopRegistration[] { }), p => p.Planned);
            FactorCalculator calculator4 = new FactorCalculator(new LocalProduction(new TimeSpan(5, 0, 0), new ProductionStopRegistration[] { }), p => p.Planned);
            FactorCalculator calculator5 = new FactorCalculator(new LocalProduction(new TimeSpan(10, 0, 0), new ProductionStopRegistration[] 
            { 
                new ProductionStopRegistration(new ProductionStop("Test 1"), new TimeSpan(4, 30, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 2", false), new TimeSpan(1, 0, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 3", false), new TimeSpan(0, 30, 0)),
                new ProductionStopRegistration(new ProductionStop("Test 4", false), new TimeSpan(4, 0, 0))
            }), p => p.Planned);

            List<FactorCalculator> calculators = new List<FactorCalculator>(new []{ calculator1, calculator2, calculator3, calculator4});

            Assert.AreEqual<double>(1,
                                    FactorCalculator.ComputedWeightedAverage(calculators,
                                                                             p => p.Availability, p => true));
                                                                             

            calculators.Add(calculator5);
            Assert.AreEqual<double>(2.0/3.0,
                                    FactorCalculator.ComputedWeightedAverage(calculators,
                                                                             p => p.Availability, p=>true));
        }
    }
}
