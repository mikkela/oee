using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE
{
    [Serializable]
    public sealed class Pair<TFirst, TSecond> : ValueObject
    {
        private readonly TFirst first;
        private readonly TSecond second;

        public Pair(TFirst first, TSecond second)
        {
            this.first = first;
            this.second = second;
        }

        public TFirst First
        {
            get { return first; }
        }

        public TSecond Second
        {
            get { return second; }
        }
    }
}
