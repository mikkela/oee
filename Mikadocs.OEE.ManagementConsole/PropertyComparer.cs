using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Mikadocs.OEE.ManagementConsole
{
    public class PropertyComparer<T> : IComparer<T>
    {
        private readonly System.Reflection.PropertyInfo _propertyInfo;
        private readonly ListSortDirection _sortDirection;

        public PropertyComparer(ListSortDirection sortDirection, string propertyToSort)
        {
            _sortDirection = sortDirection;
            _propertyInfo = typeof(T).GetProperty(propertyToSort, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.FlattenHierarchy | System.Reflection.BindingFlags.IgnoreCase);
        }

        public int Compare(T x, T y)
        {
            object xValue = _propertyInfo.GetValue(x, null);
            object yValue = _propertyInfo.GetValue(y, null);
            int result;
            if ((_sortDirection == ListSortDirection.Ascending))
            {
                result = System.Collections.Comparer.Default.Compare(xValue, yValue);
            }
            else
            {
                result = System.Collections.Comparer.Default.Compare(yValue, xValue);
            }

            return result;
        }
    }
}
