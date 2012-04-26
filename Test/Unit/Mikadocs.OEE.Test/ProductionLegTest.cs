using System;
using System.Text;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mikadocs.OEE.Test
{
    /// <summary>
    /// Summary description for ProductionDayTest
    /// </summary>
    [TestClass]
    public class ProductionLegTest
    {
        public ProductionLegTest()
        {       
            
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

        #region Local definitions

        #endregion

        #region Tests        
        private ProductionStop stop1 = new ProductionStop("MyStop 1");
        private ProductionStop stop2 = new ProductionStop("MyStop 2");
        private ProductionStop stop3 = new ProductionStop("MyStop 3");

        [TestMethod]
        public void CreateProductionLeg()
        {
            Production production = new Production("Machine A", new ProductNumber("11232"), new OrderNumber("1234"), 1000, 124);
            ProductionTeam team = new ProductionTeam("Team");
            DateTime start = new DateTime(2008, 10, 12, 8, 30, 0);
            ProductionShift shift = production.AddProductionShift(team, start.Date);

            long counterStart = 9956;
            
            ProductionLeg leg =  shift.AddProductionLeg(start, counterStart);

            Assert.AreEqual<DateTime>(start, leg.ProductionStart);
            Assert.AreEqual<long>(counterStart, leg.CounterStart);           
        }
        
        [TestMethod]
        public void AddStopsToProductionLeg()
        {
            Production production = new Production("Machine A", new ProductNumber("11232"), new OrderNumber("1234"), 1000, 124);
            ProductionShift shift = production.AddProductionShift(new ProductionTeam("T"), DateTime.Now.Date);
            ProductionLeg leg = shift.AddProductionLeg(DateTime.Now, 0);

            CollectionAssert.AreEquivalent(new ProductionStopRegistration[] { }, new List<ProductionStopRegistration>(leg.ProductionStopRegistrations));
            
            leg.AddProductionStopRegistration(new ProductionStopRegistration(stop1, new TimeSpan(0, 10, 0)));
            CollectionAssert.AreEquivalent(new [] { new ProductionStopRegistration(stop1, new TimeSpan(0, 10, 0)) }, new List<ProductionStopRegistration>(leg.ProductionStopRegistrations));
            
            leg.AddProductionStopRegistration(new ProductionStopRegistration(stop3, new TimeSpan(0, 35, 0)));
            CollectionAssert.AreEquivalent(new [] { new ProductionStopRegistration(stop1, new TimeSpan(0, 10, 0)), new ProductionStopRegistration(stop3, new TimeSpan(0, 35, 0)) }, new List<ProductionStopRegistration>(leg.ProductionStopRegistrations));
            
            leg.AddProductionStopRegistration(new ProductionStopRegistration(stop1, new TimeSpan(0, 12, 0)));
            CollectionAssert.AreEquivalent(new [] { new ProductionStopRegistration(stop1, new TimeSpan(0, 10, 0)), new ProductionStopRegistration(stop1, new TimeSpan(0, 12, 0)), new ProductionStopRegistration(stop3, new TimeSpan(0, 35, 0)) }, new List<ProductionStopRegistration>(leg.ProductionStopRegistrations));            
        }

        [TestMethod]
        public void ProductionStatistics()
        {
            DateTime start = new DateTime(2008, 10, 12, 8, 30, 0);
            DateTime end = new DateTime(2008, 10, 12, 14, 45, 0);
            long counterStart = 1111;
            long counterEnd = 12342;
            long discardedItems = 534;

            Production production = new Production("Machine A", new ProductNumber("11232"), new OrderNumber("1234"), 1000, 124);
            ProductionShift shift = production.AddProductionShift(new ProductionTeam("T"), DateTime.Now.Date);
            ProductionLeg leg = shift.AddProductionLeg(start, counterStart);

            leg.UpdateStatistics(end, counterEnd, discardedItems);
                
            Assert.AreEqual<long>(11231, leg.ProducedItems);
            Assert.AreEqual<long>(10697, leg.ProducedApprovedItems);
            Assert.AreEqual<TimeSpan>(new TimeSpan(6, 15, 0), leg.ProductionTime);            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UpdateWithProductionStartAfterProductionEnd()
        {
            DateTime time = DateTime.Now;

            Production production = new Production("Machine A", new ProductNumber("11232"), new OrderNumber("1234"), 1000, 124);
            ProductionShift shift = production.AddProductionShift(new ProductionTeam("T"), DateTime.Now.Date);
            ProductionLeg leg = shift.AddProductionLeg(time, 0);

            leg.UpdateStatistics(time.AddMinutes(-1), 0, 0);
        }

        [TestMethod]
        public void UpdateWithProductionStartSameAsProductionEnd()
        {
            DateTime time = DateTime.Now;

            Production production = new Production("Machine A", new ProductNumber("11232"), new OrderNumber("1234"), 1000, 124);
            ProductionShift shift = production.AddProductionShift(new ProductionTeam("T"), DateTime.Now.Date);
            ProductionLeg leg = shift.AddProductionLeg(time, 0);

            leg.UpdateStatistics(time, 0, 0);            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateWithNegativeCounterStart()
        {
            DateTime time = DateTime.Now;

            Production production = new Production("Machine A", new ProductNumber("11232"), new OrderNumber("1234"), 1000, 124);
            ProductionShift shift = production.AddProductionShift(new ProductionTeam("T"), DateTime.Now.Date);
            ProductionLeg leg = shift.AddProductionLeg(DateTime.Now, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UpdateWithNegativeCounterEnd()
        {
            DateTime time = DateTime.Now;

            Production production = new Production("Machine A", new ProductNumber("11232"), new OrderNumber("1234"), 1000, 124);
            ProductionShift shift = production.AddProductionShift(new ProductionTeam("T"), DateTime.Now.Date);
            ProductionLeg leg = shift.AddProductionLeg(time, 0);

            leg.UpdateStatistics(time.AddMinutes(10), -2, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UpdateWithNegativeDiscarded()
        {
            DateTime time = DateTime.Now;

            Production production = new Production("Machine A", new ProductNumber("11232"), new OrderNumber("1234"), 1000, 124);
            ProductionShift shift = production.AddProductionShift(new ProductionTeam("T"), DateTime.Now.Date);
            ProductionLeg leg = shift.AddProductionLeg(time, 0);

            leg.UpdateStatistics(time.AddMinutes(10), 50, -5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UpdateWithCounterEndSmallerThanCounterStart()
        {
            DateTime time = DateTime.Now;

            Production production = new Production("Machine A", new ProductNumber("11232"), new OrderNumber("1234"), 1000, 124);
            ProductionShift shift = production.AddProductionShift(new ProductionTeam("T"), DateTime.Now.Date);
            ProductionLeg leg = shift.AddProductionLeg(time, 400);

            leg.UpdateStatistics(time.AddMinutes(10), 300, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UpdateWithDiscardedItemsGreaterThanProducedItems()
        {
            DateTime time = DateTime.Now;

            Production production = new Production("Machine A", new ProductNumber("11232"), new OrderNumber("1234"), 1000, 124);
            ProductionShift shift = production.AddProductionShift(new ProductionTeam("T"), DateTime.Now.Date);
            ProductionLeg leg = shift.AddProductionLeg(time, 0);

            leg.UpdateStatistics(time.AddMinutes(10), 50, 60);
        }
        
        #endregion
    }
}
