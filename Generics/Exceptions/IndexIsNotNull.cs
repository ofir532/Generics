using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Exceptions
{
    internal class IndexIsNotNull : Exception
    {
        public IndexIsNotNull()
        {
        }

        public IndexIsNotNull(string? message) : base(message)
        {
        }

        public IndexIsNotNull(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected IndexIsNotNull(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
