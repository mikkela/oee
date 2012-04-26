using System;
using System.Collections.Generic;
using System.Text;

namespace Mikadocs.OEE.Repository
{
    [Serializable]
    public class RepositoryException : Exception
    {
        public RepositoryException() : this("An exception occurred in the repository.", null) { }
        public RepositoryException(string msg) : this(msg, null) { }
        public RepositoryException(string msg, Exception innerException) : base(msg, innerException) { }
    }
}
