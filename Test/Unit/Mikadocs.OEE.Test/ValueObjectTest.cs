using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mikadocs.OEE.Test
{
    /// <summary>
    /// Summary description for ValueObjectTest
    /// </summary>
    [TestClass]
    public class ValueObjectTest
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
        private class MyValueObject : ValueObject
        {
            private string s;
            private int i;

            public MyValueObject(string s, int i)
            {
                this.s = s;
                this.i = i;
            }

            public string S
            {
                get { return s; }
            }

            public int I
            {
                get { return i; }
            }
        }

        private class MyInheritedValueObject : MyValueObject
        {
            public MyInheritedValueObject(string s, int i)
                : base(s, i)
            {

            }
        }

        private class MyExtendedValueObject : MyValueObject
        {
            private double d;

            public MyExtendedValueObject(string s, int i, double d)
                : base(s, i)
            {
                this.d = d;
            }

            public double D { get { return d; } }
        }

        private class MySimilarValueObject : ValueObject
        {
            private string s;
            private int i;

            public MySimilarValueObject(string s, int i)
            {
                this.s = s;
                this.i = i;
            }

            public string S
            {
                get { return s; }
            }

            public int I
            {
                get { return i; }
            }
        }

        private class MyOtherValueObject : ValueObject
        {

        }

        private class MyValueObjectWithCollections : ValueObject
        {
            private IList<string> list1 = new List<string>();
            private IList list2 = new ArrayList();
            private IDictionary<int, string> dic1 = new Dictionary<int, string>();
            private IDictionary dic2 = new Hashtable();
            public MyValueObjectWithCollections(IEnumerable<string> strings)
            {
                int index = 0;
                foreach (string s in strings)
                {
                    list1.Add(s);
                    list2.Add(s);
                    dic1.Add(index, s);
                    dic2.Add(s, index);
                    index++;
                }

            }
        }

        private class MyValueObjectWithArray : ValueObject
        {
            private int[] arr;

            public MyValueObjectWithArray(int[] arr)
            {
                this.arr = arr;
            }
        }

        private class MyObjectWithCollectionOfMyValueObjectObjects : ValueObject
        {
            private IList<MyValueObject> myValueObjects;
            public MyObjectWithCollectionOfMyValueObjectObjects(IEnumerable<MyValueObject> myValueObjects)
            {
                this.myValueObjects = new List<MyValueObject>(myValueObjects);
            }

        }

        private class Circular1 : ValueObject
        {
            private Circular1 other;

            public Circular1 Other
            {
                get { return other; }
                set { other = value; }
            }
        }

        private class Circular2 : ValueObject
        {
            private Circular3 other;

            public Circular3 Other
            {
                get { return other; }
                set { other = value; }
            }


        }

        private class Circular3 : ValueObject
        {
            private Circular4 other;

            public Circular4 Other
            {
                get { return other; }
                set { other = value; }
            }
        }

        private class Circular4 : ValueObject
        {
            private Circular2 other;

            public Circular2 Other
            {
                get { return other; }
                set { other = value; }
            }
        }

        private class Circular5 : ValueObject
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
        public void TwoValueObjectsWithSameValuesAreEqual()
        {
            MyValueObject object1 = new MyValueObject("string", 100);
            MyValueObject object2 = new MyValueObject("string", 100);

            Assert.AreNotSame(object1, object2);
            Assert.AreEqual(object1, object1);
            Assert.AreEqual(object1, object2);
            Assert.AreEqual(object2, object1);
            Assert.AreEqual(object1.GetHashCode(), object2.GetHashCode());
            Assert.AreEqual(object2.GetHashCode(), object1.GetHashCode());
        }

        [TestMethod]
        public void TwoValueObjectsWithDifferentValuesAreNotEqual1()
        {
            MyValueObject object1 = new MyValueObject("string", 100);
            MyValueObject object2 = new MyValueObject("string1", 100);

            Assert.AreNotSame(object1, object2);
            Assert.AreEqual(object1, object1);
            Assert.AreNotEqual(object1, object2);
            Assert.AreNotEqual(object2, object1);
            Assert.AreNotEqual(object1.GetHashCode(), object2.GetHashCode());
            Assert.AreNotEqual(object2.GetHashCode(), object1.GetHashCode());
        }

        [TestMethod]
        public void TwoValueObjectsWithDifferentValuesAreNotEqual2()
        {
            MyValueObject object1 = new MyValueObject("string", 100);
            MyValueObject object2 = new MyValueObject("string", 101);

            Assert.AreNotSame(object1, object2);
            Assert.AreEqual(object1, object1);
            Assert.AreNotEqual(object1, object2);
            Assert.AreNotEqual(object2, object1);
            Assert.AreNotEqual(object1.GetHashCode(), object2.GetHashCode());
            Assert.AreNotEqual(object2.GetHashCode(), object1.GetHashCode());
        }

        [TestMethod]
        public void TwoValueObjectsWithSameValuesButDifferentTypesAreNotEqual()
        {
            MyValueObject object1 = new MyValueObject("string", 100);
            MySimilarValueObject object2 = new MySimilarValueObject("string", 100);
            MyInheritedValueObject object3 = new MyInheritedValueObject("string", 100);
            MyExtendedValueObject object4 = new MyExtendedValueObject("string", 100, 102);

            Assert.AreNotSame(object1, object2);
            Assert.AreNotSame(object1, object3);
            Assert.AreNotSame(object1, object4);

            Assert.AreEqual(object1, object1);

            Assert.AreNotEqual(object1, object2);
            Assert.AreNotEqual(object2, object1);

            Assert.AreNotEqual(object1, object3);
            Assert.AreNotEqual(object3, object1);

            Assert.AreNotEqual(object1, object4);
            Assert.AreNotEqual(object4, object1);

            Assert.AreNotEqual(object1.GetHashCode(), object2.GetHashCode());
            Assert.AreNotEqual(object2.GetHashCode(), object1.GetHashCode());

            Assert.AreNotEqual(object1.GetHashCode(), object3.GetHashCode());
            Assert.AreNotEqual(object3.GetHashCode(), object1.GetHashCode());

            Assert.AreNotEqual(object1.GetHashCode(), object4.GetHashCode());
            Assert.AreNotEqual(object4.GetHashCode(), object1.GetHashCode());
        }

        [TestMethod]
        public void ObjectsWithCollectionsTest()
        {
            MyValueObjectWithCollections o1 = new MyValueObjectWithCollections(new string[] { });
            MyValueObjectWithCollections o2 = new MyValueObjectWithCollections(new string[] { });

            MyValueObjectWithCollections o3 = new MyValueObjectWithCollections(new string[] { "s1", "s2", "s3" });
            MyValueObjectWithCollections o4 = new MyValueObjectWithCollections(new string[] { "s1", "s2", "s3" });
            MyValueObjectWithCollections o5 = new MyValueObjectWithCollections(new string[] { "s1", "s2" });
            MyValueObjectWithCollections o6 = new MyValueObjectWithCollections(new string[] { "s1", "s2", "s3", "s4" });

            Assert.AreEqual(o1, o1);
            Assert.AreEqual(o1, o2);
            Assert.AreEqual(o2, o1);
            Assert.AreNotEqual(o1, o3);
            Assert.AreNotEqual(o3, o1);
            Assert.AreNotEqual(o1, o4);
            Assert.AreNotEqual(o4, o1);
            Assert.AreNotEqual(o1, o5);
            Assert.AreNotEqual(o5, o1);
            Assert.AreNotEqual(o1, o6);
            Assert.AreNotEqual(o6, o1);

            Assert.AreEqual(o3, o3);
            Assert.AreEqual(o3, o4);
            Assert.AreEqual(o4, o3);
            Assert.AreNotEqual(o3, o5);
            Assert.AreNotEqual(o5, o3);
            Assert.AreNotEqual(o3, o6);
            Assert.AreNotEqual(o6, o3);
        }

        [TestMethod]
        public void ObjectsWithArrayTest()
        {
            MyValueObjectWithArray o1 = new MyValueObjectWithArray(new int[] { });
            MyValueObjectWithArray o2 = new MyValueObjectWithArray(new int[] { });

            MyValueObjectWithArray o3 = new MyValueObjectWithArray(new int[] { 1, 2, 3 });
            MyValueObjectWithArray o4 = new MyValueObjectWithArray(new int[] { 1, 2, 3 });
            MyValueObjectWithArray o5 = new MyValueObjectWithArray(new int[] { 1, 2 });
            MyValueObjectWithArray o6 = new MyValueObjectWithArray(new int[] { 1, 2, 3, 4 });

            Assert.AreEqual(o1, o1);
            Assert.AreEqual(o1, o2);
            Assert.AreEqual(o2, o1);
            Assert.AreNotEqual(o1, o3);
            Assert.AreNotEqual(o3, o1);
            Assert.AreNotEqual(o1, o4);
            Assert.AreNotEqual(o4, o1);
            Assert.AreNotEqual(o1, o5);
            Assert.AreNotEqual(o5, o1);
            Assert.AreNotEqual(o1, o6);
            Assert.AreNotEqual(o6, o1);

            Assert.AreEqual(o3, o3);
            Assert.AreEqual(o3, o4);
            Assert.AreEqual(o4, o3);
            Assert.AreNotEqual(o3, o5);
            Assert.AreNotEqual(o5, o3);
            Assert.AreNotEqual(o3, o6);
            Assert.AreNotEqual(o6, o3);
        }


        [TestMethod]
        public void ToStringTest()
        {
            MyValueObject object1 = new MyValueObject("string", 100);
            MySimilarValueObject object2 = new MySimilarValueObject("string", 100);
            MyInheritedValueObject object3 = new MyInheritedValueObject("string", 100);
            MyExtendedValueObject object4 = new MyExtendedValueObject("string", 100, 102);
            MyOtherValueObject object5 = new MyOtherValueObject();

            Assert.AreEqual(object1.ToString(), "Mikadocs.OEE.Test.ValueObjectTest+MyValueObject with values: (i: (100), s: (string))");
            Assert.AreEqual(object2.ToString(), "Mikadocs.OEE.Test.ValueObjectTest+MySimilarValueObject with values: (i: (100), s: (string))");
            Assert.AreEqual(object3.ToString(), "Mikadocs.OEE.Test.ValueObjectTest+MyInheritedValueObject with values: (i: (100), s: (string))");
            Assert.AreEqual(object4.ToString(), "Mikadocs.OEE.Test.ValueObjectTest+MyExtendedValueObject with values: (d: (102), i: (100), s: (string))");
            Assert.AreEqual(object5.ToString(), "Mikadocs.OEE.Test.ValueObjectTest+MyOtherValueObject with values: (none)");
        }

        [TestMethod]
        public void OwnCircularLinkedEntities()
        {
            Circular1 o = new Circular1();

            o.Other = o;

            Assert.IsTrue(o.Equals(o));
            Assert.AreNotEqual(o.GetHashCode(), 0);
            Assert.AreNotEqual(o.ToString().Length, 0);
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
            Assert.AreNotEqual(o1.ToString().Length, 0);
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
            Assert.AreNotEqual(o2.ToString().Length, 0);
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
            Assert.AreNotEqual(o5.ToString().Length, 0);
        }
        #endregion
    }
}
