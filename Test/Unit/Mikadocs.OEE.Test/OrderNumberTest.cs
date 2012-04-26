using System;
using System.Text;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mikadocs.OEE.Test
{
    /// <summary>
    /// Summary description for OrderNumberTest
    /// </summary>
    [TestClass]
    public class OrderNumberTest
    {
        public OrderNumberTest()
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
        [TestInitialize()]
        public void MyTestInitialize()
        {
            OrderNumber.Validation = new OrderNumber.ValidationRule(delegate(string number) { return true; });
        }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void CreateOrderNumberWithoutValidation()
        {
            OrderNumber orderNumber = new OrderNumber("My order number");
            Assert.AreEqual<string>("My order number", orderNumber.Number);
        }

        [TestMethod]
        public void CreateOrderNumberWithValidation()
        {
            OrderNumber.ValidationRule oldRule = OrderNumber.Validation;
            OrderNumber.Validation = new OrderNumber.ValidationRule(delegate(string number) { return number.Equals("123"); });

            OrderNumber orderNumber = new OrderNumber("123");
            Assert.AreEqual<string>("123", orderNumber.Number);

            bool exceptionCaught = false;
            try
            {
                orderNumber = new OrderNumber("124");
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual<string>("The order number 124 is not a valid order number.", e.Message);
                exceptionCaught = true;
            }
            finally
            {
                OrderNumber.Validation = oldRule;
            }
            Assert.IsTrue(exceptionCaught);
        }
    }
}
