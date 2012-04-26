using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE
{
    public class OrderNumber : ValueObject
    {
        public delegate bool ValidationRule(string orderNumber);

        private static ValidationRule validation = new ValidationRule(delegate(string orderNumber) { return true; });
        public static ValidationRule Validation
        {
            get { return validation; }
            set { validation = value; }
        }

        private string number;

        internal OrderNumber()
        {

        }
        public OrderNumber(string number)
        {
            if (!Validation.Invoke(number))
                throw new ArgumentException(string.Format("The order number {0} is not a valid order number.", number));
            this.number = number;
        }

        public string Number
        {
            get { return number; }
        }
    }
}
