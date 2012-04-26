using System;
using System.Text;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mikadocs.OEE.Test
{
    /// <summary>
    /// Summary description for VisitorTest
    /// </summary>
    [TestClass]
    public class VisitorTest
    {
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
        private class MyBaseClass
        {
            public void Visit(Visitor<MyBaseClass> visitor)
            {
                visitor.Visit(this);
            }    
        }

        private class MyDerivedClass : MyBaseClass
        {
           
        }

        private class MyOtherDerivedClass : MyBaseClass
        {
            
        }

        private class MyDerivedClassVisitor : Visitor<MyBaseClass>
        {
            private bool derivedClassVisited = false;
            private bool otherDerivedClassVisited = false;
            private bool baseClassVisited = false;

            public bool BaseClassVisited
            {
                get { return baseClassVisited; }
            }

            public bool DerivedClassVisited
            {
                get { return derivedClassVisited; }
            }

            public bool OtherDerivedClassVisited
            {
                get { return otherDerivedClassVisited; }
            }

            private void DoVisit(MyDerivedClass obj)
            {
                derivedClassVisited = true;
            }
        }

        private class MyBaseClassVisitor : Visitor<MyBaseClass>
        {
            private bool derivedClassVisited = false;
            private bool otherDerivedClassVisited = false;
            private bool baseClassVisited = false;

            public virtual bool BaseClassVisited
            {
                get { return baseClassVisited; }
            }

            public virtual bool DerivedClassVisited
            {
                get { return derivedClassVisited; }
            }

            public virtual bool OtherDerivedClassVisited
            {
                get { return otherDerivedClassVisited; }
            }

            protected void DoVisit(MyBaseClass obj)
            {
                baseClassVisited = true;
            }
        }

        private class BothClassVisitor : Visitor<MyBaseClass>
        {
            private bool derivedClassVisited = false;
            private bool otherDerivedClassVisited = false;
            private bool baseClassVisited = false;

            public bool BaseClassVisited
            {
                get { return baseClassVisited; }
            }

            public bool DerivedClassVisited
            {
                get { return derivedClassVisited; }
            }

            public bool OtherDerivedClassVisited
            {
                get { return otherDerivedClassVisited; }
            }

            internal void DoVisit(MyDerivedClass obj)
            {
                derivedClassVisited = true;
            }

            public void DoVisit(MyBaseClass obj)
            {
                baseClassVisited = true;
            }
        }

        private class InhertiedVisitor : MyBaseClassVisitor
        {
            private bool otherDerivedClassVisitor = false;
            private bool baseClassVisited = false;

            public override bool OtherDerivedClassVisited
            {
                get { return otherDerivedClassVisitor; }
            }

            public override bool BaseClassVisited
            {
                get { return baseClassVisited; }
            }

            public void DoVisit(MyBaseClass obj)
            {
                baseClassVisited = false;
            }

            protected internal void DoVisit(MyOtherDerivedClass obj)
            {
                otherDerivedClassVisitor = true;
            }
        } 
        #endregion

        #region Test
        [TestMethod]
        public void VisitBaseClass()
        {
            MyBaseClass o = new MyBaseClass();

            MyBaseClassVisitor visitor1 = new MyBaseClassVisitor();
            o.Visit(visitor1);
            Assert.IsTrue(visitor1.BaseClassVisited);

            MyDerivedClassVisitor visitor2 = new MyDerivedClassVisitor();
            o.Visit(visitor2);
            Assert.IsFalse(visitor2.BaseClassVisited);

            BothClassVisitor visitor3 = new BothClassVisitor();
            o.Visit(visitor3);
            Assert.IsTrue(visitor3.BaseClassVisited);

            InhertiedVisitor visitor4 = new InhertiedVisitor();
            o.Visit(visitor4);
            Assert.IsFalse(visitor4.BaseClassVisited);
        }

        [TestMethod]
        public void VisitDerivedClass()
        {
            MyDerivedClass o = new MyDerivedClass();

            MyBaseClassVisitor visitor1 = new MyBaseClassVisitor();
            o.Visit(visitor1);
            Assert.IsFalse(visitor1.DerivedClassVisited);

            MyDerivedClassVisitor visitor2 = new MyDerivedClassVisitor();
            o.Visit(visitor2);
            Assert.IsTrue(visitor2.DerivedClassVisited);

            BothClassVisitor visitor3 = new BothClassVisitor();
            o.Visit(visitor3);
            Assert.IsTrue(visitor3.DerivedClassVisited);

            InhertiedVisitor visitor4 = new InhertiedVisitor();
            o.Visit(visitor4);
            Assert.IsFalse(visitor4.DerivedClassVisited);
        }

        [TestMethod]
        public void VisitOtherDerivedClass()
        {
            MyOtherDerivedClass o = new MyOtherDerivedClass();

            MyBaseClassVisitor visitor1 = new MyBaseClassVisitor();
            o.Visit(visitor1);
            Assert.IsFalse(visitor1.OtherDerivedClassVisited);

            MyDerivedClassVisitor visitor2 = new MyDerivedClassVisitor();
            o.Visit(visitor2);
            Assert.IsFalse(visitor2.OtherDerivedClassVisited);

            BothClassVisitor visitor3 = new BothClassVisitor();
            o.Visit(visitor3);
            Assert.IsFalse(visitor3.OtherDerivedClassVisited);

            InhertiedVisitor visitor4 = new InhertiedVisitor();
            o.Visit(visitor4);
            Assert.IsTrue(visitor4.OtherDerivedClassVisited);
        }

        #endregion
    }
}
