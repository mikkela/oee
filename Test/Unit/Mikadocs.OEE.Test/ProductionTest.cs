using System;
using System.Text;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mikadocs.OEE.Test
{
    /// <summary>
    /// Summary description for ProductionTest
    /// </summary>
    [TestClass]
    public class ProductionTest
    {
        public ProductionTest()
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
        public void AddShift()
        {
            Production production = new Production("Machine A", new ProductNumber("11232"), new OrderNumber("1234"), 1000, 124);

            ProductionTeam team = new ProductionTeam("Team 1");
            
            DateTime start = new DateTime(2008, 10, 12, 8, 30, 0);
            
            ProductionShift shift = production.AddProductionShift(team, start);
            
            CollectionAssert.AreEquivalent(new [] { shift }, new List<ProductionShift>(production.Shifts));
        }

        [TestMethod]
        public void AddShiftsOnSameDayWithDifferentTeam()
        {
            Production production = new Production("Machine A", new ProductNumber("11232"), new OrderNumber("1234"), 1000, 124);

            ProductionTeam team1 = new ProductionTeam("Team 1");
            ProductionTeam team2 = new ProductionTeam("Team 2");

            DateTime start1 = new DateTime(2008, 10, 12, 8, 30, 0);
            DateTime start2 = new DateTime(2008, 10, 12, 16, 30, 0);
            
            ProductionShift shift1 = production.AddProductionShift(team1, start1);
            ProductionShift shift2 = production.AddProductionShift(team2, start2);

            CollectionAssert.AreEquivalent(new [] { shift1, shift2 }, new List<ProductionShift>(production.Shifts));
        }

        [TestMethod]
        public void AddShiftsOnDifferentDaysWithSameTeam()
        {
            Production production = new Production("Machine A", new ProductNumber("11232"), new OrderNumber("1234"), 1000, 124);

            ProductionTeam team = new ProductionTeam("Team 1");            

            DateTime start1 = new DateTime(2008, 10, 12, 8, 30, 0);
            DateTime start2 = new DateTime(2008, 11, 12, 8, 30, 0);
            
            ProductionShift shift1 = production.AddProductionShift(team, start1);
            ProductionShift shift2 = production.AddProductionShift(team, start2);

            CollectionAssert.AreEquivalent(new [] { shift1, shift2 }, new List<ProductionShift>(production.Shifts));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddShiftsOnSameDayWithSameTeam()
        {
            Production production = new Production("Machine A", new ProductNumber("11232"), new OrderNumber("1234"), 1000, 124);

            ProductionTeam team = new ProductionTeam("Team 1");
            
            DateTime start = new DateTime(2008, 10, 12, 8, 30, 0);
            
            ProductionShift shift1 = production.AddProductionShift(team, start);
            ProductionShift shift2 = production.AddProductionShift(team, start.AddHours(1));            
        }

        //[TestMethod]
        //public void AddShiftsSpanningMultipleDaysWithoutContinousProduction()
        //{
        //    Production production = new Production("Machine A", new ProductNumber("11232"), new OrderNumber("1234"), 1000, 124);

        //    ProductionTeam team = new ProductionTeam("Team 1");

        //    ProductionShift shift1 = production.AddProductionShift(team, new DateTime(2008, 10, 12));
            
        //    ProductionShift shift2 = production.AddProductionShift(team, new DateTime(2008, 10, 13));
            
        //    ProductionShift shift3 = production.AddProductionShift(team, new DateTime(2008, 10, 14));
            
        //    Assert.AreEqual<TimeSpan>(new TimeSpan(24, 0, 0), production.Duration);
        //    Assert.AreEqual<long>(4000, production.ProducedItems);
        //    Assert.AreEqual<long>(55, production.DiscardedItems);
        //}
    }
}
