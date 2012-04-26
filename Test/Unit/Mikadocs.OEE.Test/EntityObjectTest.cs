using System;
using System.Text;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mikadocs.OEE.Test
{
    /// <summary>
    /// Summary description for EntityObjectTest
    /// </summary>
    [TestClass]
    public class EntityObjectTest
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
        private class MyEntityObject : EntityObject
        {
            private string name;

            public MyEntityObject(string name) : this(0, 0, name)
            {
                
            }

            public MyEntityObject(long id, int version, string name) : base(id, version)
            {
                this.name = name;
            }
        }

        private class MyExtendedEntityObject : MyEntityObject
        {
            private int age;

            public MyExtendedEntityObject(string name, int age)
                : this(0, 0, name, age)
            {

            }

            public MyExtendedEntityObject(long id, int version, string name, int age)
                : base(id, version, name)
            {
                this.age = age;
            }
        }

        private class MyOtherEntityObject : EntityObject
        {
            public MyOtherEntityObject()
            {
            }

            public MyOtherEntityObject(long id, int version) : base(id, version)
            {
                
            }
        }

        private class MyOtherOtherEntityObject : EntityObject
        {
            private string s;
            private int i;
            private double d;

            public MyOtherOtherEntityObject(string s, int i, double d)               
            {
                this.s = s;
                this.i = i;
                this.d = d;
            }
            
        }

        private class Circular1 : EntityObject
        {
            private Circular1 other;

            public Circular1 Other
            {
                get { return other; }
                set { other = value; }
            }
        }

        private class Circular2 : EntityObject  {
            private Circular3 other;

            public Circular3 Other
            {
                get { return other; }
                set { other = value; }
            }


        }

        private class Circular3 : EntityObject {
            private Circular4 other;

            public Circular4 Other
            {
                get { return other; }
                set { other = value; }
            }
        }

        private class Circular4 : EntityObject
        {
            private Circular2 other;

            public Circular2 Other
            {
                get { return other; }
                set { other = value; }
            }
        }

        private class Circular5 : EntityObject
        {
            private Circular1 other;

            public Circular1 Other
            {
                get { return other; }
                set { other = value; }
            }
        }
        #endregion

        #region Test

        [TestMethod]
        public void TwoEntityObjectsWithSameTypeSameIdAndSameVersionAreEqual()
        {
            MyEntityObject o1 = new MyEntityObject(1, 1, "Mikkel1");
            MyEntityObject o2 = new MyEntityObject(1, 1, "Mikkel2");

            Assert.AreNotSame(o1, o2);
            Assert.AreEqual(o1, o1);
            Assert.AreEqual(o1, o2);
            Assert.AreEqual(o2, o1);
            Assert.AreEqual(o1.GetHashCode(), o2.GetHashCode());
            Assert.AreEqual(o2.GetHashCode(), o1.GetHashCode());
        }

        [TestMethod]
        public void TwoEntityObjectsWithSameTypeAndVersionButDifferentIdAreDifferent()
        {
            MyEntityObject o1 = new MyEntityObject(1, 1, "Mikkel1");
            MyEntityObject o2 = new MyEntityObject(2, 1, "Mikkel2");

            Assert.AreNotSame(o1, o2);
            Assert.AreEqual(o1, o1);
            Assert.AreNotEqual(o1, o2);
            Assert.AreNotEqual(o2, o1);
            Assert.AreNotEqual(o1.GetHashCode(), o2.GetHashCode());
            Assert.AreNotEqual(o2.GetHashCode(), o1.GetHashCode());
        }

        [TestMethod]
        public void TwoEntityObjectsWithSameTypeAndIdButDifferentVersionAreDifferent()
        {
            MyEntityObject o1 = new MyEntityObject(1, 1, "Mikkel1");
            MyEntityObject o2 = new MyEntityObject(1, 2, "Mikkel2");

            Assert.AreNotSame(o1, o2);
            Assert.AreEqual(o1, o1);
            Assert.AreNotEqual(o1, o2);
            Assert.AreNotEqual(o2, o1);
            Assert.AreNotEqual(o1.GetHashCode(), o2.GetHashCode());
            Assert.AreNotEqual(o2.GetHashCode(), o1.GetHashCode());
        }

        [TestMethod]
        public void TwoEntityObjectsWithSameIdAndVersionButDifferentTypesAreDifferent()
        {
            MyEntityObject o1 = new MyEntityObject(1, 1, "Mikkel");
            MyOtherEntityObject o2 = new MyOtherEntityObject(1, 1);
            MyExtendedEntityObject o3 = new MyExtendedEntityObject(1, 1, "Mikkel", 36);

            Assert.AreNotSame(o1, o2);
            Assert.AreNotSame(o1, o3);
            Assert.AreEqual(o1, o1);
            Assert.AreNotEqual(o1, o2);
            Assert.AreNotEqual(o2, o1);
            Assert.AreNotEqual(o1, o3);
            Assert.AreNotEqual(o3, o1);
            Assert.AreNotEqual(o1.GetHashCode(), o2.GetHashCode());
            Assert.AreNotEqual(o2.GetHashCode(), o1.GetHashCode());
            Assert.AreNotEqual(o1.GetHashCode(), o3.GetHashCode());
            Assert.AreNotEqual(o3.GetHashCode(), o1.GetHashCode());
        }

        [TestMethod]
        public void TwoEntityObjectsWithSameTypeAndIdAndVersionButIdIsZeroAreDifferent()
        {
            MyEntityObject o1 = new MyEntityObject(0, 1, "Mikkel1");
            MyEntityObject o2 = new MyEntityObject(0, 1, "Mikkel2");

            Assert.AreNotSame(o1, o2);
            Assert.AreEqual(o1, o1);
            Assert.AreNotEqual(o1, o2);
            Assert.AreNotEqual(o2, o1);
            Assert.AreEqual(o1.GetHashCode(), o2.GetHashCode());
            Assert.AreEqual(o2.GetHashCode(), o1.GetHashCode());
        }

        [TestMethod]
        public void ToStringTest()
        {
            MyOtherEntityObject o1 = new MyOtherEntityObject(1, 1);
            MyEntityObject o2 = new MyEntityObject(1, 1, "Mikkel");
            MyOtherOtherEntityObject o3 = new MyOtherOtherEntityObject("string", 10, 4.67);
            MyExtendedEntityObject o4 = new MyExtendedEntityObject(1, 1, "Mikkel", 36);

            Assert.AreEqual(o1.ToString(), "Mikadocs.OEE.Test.EntityObjectTest+MyOtherEntityObject with id: 1, version: 1 and values: (none)");
            Assert.AreEqual(o2.ToString(), "Mikadocs.OEE.Test.EntityObjectTest+MyEntityObject with id: 1, version: 1 and values: (name: (Mikkel))");
            Assert.AreEqual(o3.ToString(), "Mikadocs.OEE.Test.EntityObjectTest+MyOtherOtherEntityObject with id: 0, version: 0 and values: (d: (4.67), i: (10), s: (string))");
            Assert.AreEqual(o4.ToString(), "Mikadocs.OEE.Test.EntityObjectTest+MyExtendedEntityObject with id: 1, version: 1 and values: (age: (36), name: (Mikkel))");
        }

        [TestMethod]
        public void OwnCircularLinkedEntities()
        {
            Circular1 o = new Circular1();            

            o.Other = o;            

            Assert.IsTrue(o.Equals(o));
            Assert.AreNotEqual(o.GetHashCode(), 0);
            Assert.AreNotEqual(o.ToString(), "");
        }

        [TestMethod]
        public void SameClassCircularLinkedEntities()
        {
            Circular1 o1 = new Circular1();
            Circular1 o2 = new Circular1();

            o1.Other = o2;
            o2.Other = o1;

            Assert.IsTrue(o1.Equals(o1));
            Assert.AreNotEqual(o1.GetHashCode(), 0);
            Assert.AreNotEqual(o1.ToString(), "");
        }

        [TestMethod]
        public void ChainedCircularLinkedEntities()
        {
            Circular2 o2 = new Circular2();
            Circular3 o3 = new Circular3();
            Circular4 o4 = new Circular4();

            o2.Other = o3;
            o3.Other = o4;
            o4.Other = o2;

            Assert.IsTrue(o2.Equals(o2));
            Assert.AreNotEqual(o2.GetHashCode(), 0);
            Assert.AreNotEqual(o2.ToString(), "");
        }

        [TestMethod]
        public void IndirectCircularLinkedEntities()
        {
            Circular1 o1 = new Circular1();
            Circular5 o5 = new Circular5();

            o1.Other = o1;
            o5.Other = o1;

            Assert.IsTrue(o5.Equals(o5));
            Assert.AreNotEqual(o5.GetHashCode(), 0);
            Assert.AreNotEqual(o5.ToString(), "");
        }
        #endregion
    }
}
