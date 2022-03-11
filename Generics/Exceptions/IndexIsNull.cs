using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Exceptions
{
    internal class IndexIsNull : Exception
    {
        public IndexIsNull()
        {
        }

        public IndexIsNull(string? message) : base(message)
        {
        }

        public IndexIsNull(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected IndexIsNull(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
