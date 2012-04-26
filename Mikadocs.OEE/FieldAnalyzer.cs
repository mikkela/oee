using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Threading;
using ICollection = System.Collections.ICollection;

namespace Mikadocs.OEE
{
    static class FieldAnalyzer
    {
        private static object _lock = new object();
        private static IDictionary<int, LinkedList<object>> callStacks = new Dictionary<int, LinkedList<object>>();

        public static string GetFieldValuesAsString(object o, Type baseType)
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("");
            StringBuilder result = new StringBuilder();
            SortedList<string, string> orderedFieldNameValueList = new SortedList<string, string>();

            IterateTypeHierarchy(o.GetType(), baseType,
                                 new IterateTypeHierarchyIterateDelegate(delegate(FieldInfo field)
                                 {
                                     orderedFieldNameValueList.Add(
                                         field.Name,
                                         string.Format("{0}: ({1})",
                                                       field.Name,
                                                       FindToString(field.GetValue(o))));
                                 }));
            foreach (string val in orderedFieldNameValueList.Values)
            {
                if (result.Length != 0)
                    result.Append(", ");
                result.Append(val);
            }

            Thread.CurrentThread.CurrentCulture = currentCulture;
            return result.ToString();
        }

        public static bool AreFieldValuesEqual(object o1, object o2)
        {
            bool result = true;
            IList<Pair<Pair<object, object>, bool>> cache = new List<Pair<Pair<object, object>, bool>>();

            IterateTypeHierarchy(o1.GetType(), typeof(ValueObject),
                                 new IterateTypeHierarchyIterateDelegate(delegate(FieldInfo field)
                                 {
                                     object val1 = field.GetValue(o1);
                                     object val2 = field.GetValue(o2);

                                     foreach (Pair<Pair<object, object>, bool> entry in cache)
                                     {
                                         if ((Object.ReferenceEquals(entry.First.First, val1) && Object.ReferenceEquals(entry.First.Second, val2)) ||
                                             (Object.ReferenceEquals(entry.First.First, val2) && Object.ReferenceEquals(entry.First.Second, val1)))
                                         {
                                             result = result && entry.Second;
                                             return;
                                         }
                                     }

                                     bool r = AreEqual(val1, val2);

                                     cache.Add(new Pair<Pair<object, object>, bool>(new Pair<object, object>(val1, val2), r));
                                     result = result && r;
                                 }));

            return result;
        }

        public static int GetFieldValuesAsHashCode(ValueObject o)
        {
            int hashCode = 0;

            IterateTypeHierarchy(o.GetType(), typeof(ValueObject),
                                 new IterateTypeHierarchyIterateDelegate(delegate(FieldInfo field)
                                 {
                                     object val = field.GetValue(o);

                                     if (val != null)
                                     {
                                         hashCode += FindHashCode(val);
                                     }
                                 }));
            return hashCode;
        }

        private delegate void IterateTypeHierarchyIterateDelegate(FieldInfo field);

        private static void IterateTypeHierarchy(Type t, Type baseType, IterateTypeHierarchyIterateDelegate callback)
        {
            while (!t.Equals(baseType))
            {
                foreach (
                    FieldInfo field in
                        t.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public |
                                    BindingFlags.FlattenHierarchy))
                {
                    callback(field);
                }
                t = t.BaseType;
            }
        }

        private static bool AreEqual(object o1, object o2)
        {
            if (o1 == null)
                return o2 == null;

            if (o2 == null)
                return false;

            if (o1 is ICollection && o2 is ICollection)
                return CollectionsEqual((ICollection)o1, (ICollection)o2);

            return o1.Equals(o2);
        }

        private static bool CollectionsEqual(ICollection o1, ICollection o2)
        {
            IEnumerator e1 = o1.GetEnumerator();
            IEnumerator e2 = o2.GetEnumerator();

            int count;
            for (count = 0; e1.MoveNext() && e2.MoveNext(); count++)
            {
                if (!AreEqual(e1.Current, e2.Current))
                    break;
            }

            if (count == o1.Count && count == o2.Count)
                return true;

            return false;
        }

        private static int FindHashCode(object obj)
        {
            LinkedListNode<object> node = GetCallStack().Last;
            while (node != null)
            {
                if (ReferenceEquals(node.Value, obj))
                {
                    // We have seen it before
                    if (obj is ValueObject)
                    {
                        return ((ValueObject)obj).InternalGetHashCode();
                    }
                    else if (obj is EntityObject)
                    {
                        return ((EntityObject)obj).InternalGetHashCode();
                    }
                }

                node = node.Previous;
            }

            GetCallStack().AddLast(obj);
            int result = obj.GetHashCode();
            GetCallStack().RemoveLast();

            return result;
        }

        private static string FindToString(object obj)
        {
            LinkedListNode<object> node = GetCallStack().Last;
            while (node != null)
            {
                if (ReferenceEquals(node.Value, obj))
                {
                    // We have seen it before
                    if (obj is ValueObject)
                    {
                        return ((ValueObject)obj).InternalToString();
                    }
                    else if (obj is EntityObject)
                    {
                        return ((EntityObject)obj).InternalToString();
                    }
                }

                node = node.Previous;
            }

            GetCallStack().AddLast(obj);
            string result = obj.ToString();
            GetCallStack().RemoveLast();

            return result;
        }

        private static LinkedList<object> GetCallStack()
        {
            lock (_lock)
            {
                if (!callStacks.ContainsKey(System.Threading.Thread.CurrentThread.ManagedThreadId))
                {
                    callStacks.Add(System.Threading.Thread.CurrentThread.ManagedThreadId, new LinkedList<object>());
                }

                return callStacks[System.Threading.Thread.CurrentThread.ManagedThreadId];
            }
        }
    }
}
