using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace Mikadocs.OEE
{
    public class Visitor<TVisited>
    {
        private object _lock = new object();
        private IList<int> currentActiveThreads = new List<int>();

        public void Visit(TVisited visited)
        {
            if (IsActiveThread())
                return;
            try
            {
                AddToActiveThreads();

                Type t = GetType();

                while (t != null)
                {
                    foreach (
                        MethodInfo method in
                            GetType().GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
                    {
                        if (method.Name.Equals("DoVisit") &&
                            method.ReturnType.Equals(typeof(void)))
                        {
                            ParameterInfo[] parameters = method.GetParameters();
                            if (parameters.Length == 1 &&
                                parameters[0].ParameterType.Equals(visited.GetType()))
                            {
                                method.Invoke(this, new object[] { visited });
                                return;
                            }
                        }
                    }
                    t = t.BaseType;
                }
            }
            finally
            {
                RemoveFromActiveThreads();
            }
        }

        private void AddToActiveThreads()
        {
            lock (_lock)
            {
                currentActiveThreads.Add(Thread.CurrentThread.ManagedThreadId);
            }
        }

        private void RemoveFromActiveThreads()
        {
            lock (_lock)
            {
                currentActiveThreads.Remove(Thread.CurrentThread.ManagedThreadId);
            }
        }

        private bool IsActiveThread()
        {
            lock (_lock)
            {
                return currentActiveThreads.Contains(Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
