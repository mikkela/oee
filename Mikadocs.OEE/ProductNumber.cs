using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE
{
    public class ProductNumber : ValueObject
    {
        public delegate bool ValidationRule(string productNumber);

        private static ValidationRule validation = new ValidationRule(delegate(string productNumber) { return true; });
        public static ValidationRule Validation
        {
            get { return validation; }
            set { validation = value; }
        }

        private string number;

        internal ProductNumber() { }

        public ProductNumber(string number)
        {
            if (!Validation.Invoke(number))
                throw new ArgumentException(string.Format("The product number {0} is not a valid product number.", number));
            this.number = number;
        }

        public string Number
        {
            get { return number; }
        }
    }
}
