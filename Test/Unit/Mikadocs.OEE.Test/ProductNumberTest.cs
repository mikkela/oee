using System;
using System.Text;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mikadocs.OEE.Test
{
    /// <summary>
    /// Summary description for ProductNumberTest
    /// </summary>
    [TestClass]
    public class ProductNumberTest
    {
        public ProductNumberTest()
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
        public void TestInitialize()
        {
        }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void CreateProductNumberWithoutValidation()
        {
            ProductNumber productNumber = new ProductNumber("My product number");
            Assert.AreEqual<string>("My product number", productNumber.Number);
        }

        [TestMethod]
        public void CreateProductNumberWithValidation()
        {
            ProductNumber.Validation = new ProductNumber.ValidationRule(delegate(string number) { return number.Equals("45343"); });

            ProductNumber productNumber = new ProductNumber("45343");
            Assert.AreEqual<string>("45343", productNumber.Number);

            bool exceptionCaught = false;
            try
            {
                productNumber = new ProductNumber("45343A");
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual<string>("The product number 45343A is not a valid product number.", e.Message);
                exceptionCaught = true;
            }

            Assert.IsTrue(exceptionCaught);
        }
    }
}
