using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Exceptions
{
    internal class IndexNotExist : Exception
    {
        public IndexNotExist()
        {
        }

        public IndexNotExist(string? message) : base(message)
        {
        }

        public IndexNotExist(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected IndexNotExist(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
