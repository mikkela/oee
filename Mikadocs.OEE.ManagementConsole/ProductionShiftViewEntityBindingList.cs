using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Mikadocs.OEE.ManagementConsole
{
    class ProductionShiftViewEntityBindingList : BindingList<ProductionShiftViewEntity>
    {
        private ListSortDirection _sortDirection;
        private PropertyDescriptor _sortProperty;
        private bool _isSorted;

        public ProductionShiftViewEntityBindingList(IEnumerable<ProductionShiftViewEntity> entities)
            : base(new List<ProductionShiftViewEntity>(entities))
        {

        }

        protected override ListSortDirection SortDirectionCore
        {
            get { return _sortDirection; }
        }

        protected override PropertyDescriptor SortPropertyCore
        {
            get { return _sortProperty; }
        }

        protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
        {
            _sortProperty = property;
            _sortDirection = direction;

            // Get list to sort
            var items = (List<ProductionShiftViewEntity>)Items;

            // Apply and set the sort, if items to sort
            if (items != null)
            {
                var pc = new PropertyComparer<ProductionShiftViewEntity>(direction, property.Name);
                items.Sort(pc);
                _isSorted = true;
            }
            else
            {
                _isSorted = false;
            }

            // Let bound controls know they should refresh their views
            this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override void RemoveSortCore()
        {
            _isSorted = false;
            _sortProperty = null;
        }

        protected override bool IsSortedCore
        {
            get
            {
                return _isSorted;
            }
        }

        protected override bool SupportsSortingCore
        {
            get
            {
                return true;
            }
        }

    }
}
