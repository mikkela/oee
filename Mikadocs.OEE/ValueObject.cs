using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE
{
    [Serializable]
    public abstract class ValueObject
    {
        public override string ToString()
        {
            string values = FieldAnalyzer.GetFieldValuesAsString(this, typeof(ValueObject));

            return string.Format("{0} with values: ({1})",
                GetType().FullName, string.IsNullOrEmpty(values) ? "none" : values);
        }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            ValueObject other = obj as ValueObject;
            if (other != null)
            {
                if (other.GetType().Equals(GetType()))
                    return FieldAnalyzer.AreFieldValuesEqual(this, obj);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return
                4653 * GetType().GetHashCode() +
                FieldAnalyzer.GetFieldValuesAsHashCode(this);
        }

        internal virtual string InternalToString()
        {
            return base.ToString();
        }

        internal virtual int InternalGetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
