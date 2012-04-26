using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE
{
    [Serializable]
    public abstract class EntityObject
    {
        private long id;
        private int version;

        public EntityObject()
            : this(0, 0)
        {
        }

        public EntityObject(long id, int version)
        {
            this.id = id;
            this.version = version;
        }

        public virtual long Id
        {
            get { return id; }
        }

        public virtual int Version
        {
            get { return version; }
        }

        public override bool Equals(object obj)
        {
            EntityObject other = obj as EntityObject;

            if (other != null)
            {
                if (id == 0)
                    return Object.ReferenceEquals(this, obj);

                return
                    other.GetType().Equals(GetType()) &&
                    other.Id == id &&
                    other.Version == version;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return
                456545 * GetType().GetHashCode() +
                43654 * (int)id + 326532 * version;
        }

        public override string ToString()
        {
            string values = FieldAnalyzer.GetFieldValuesAsString(this, typeof(EntityObject));

            return string.Format("{0} with id: {1}, version: {2} and values: ({3})",
                GetType().FullName, id, version, string.IsNullOrEmpty(values) ? "none" : values);
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
