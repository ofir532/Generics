using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Exceptions
{
    internal class IndexNotValid : Exception
    {
        public IndexNotValid()
        {
        }

        public IndexNotValid(string? message) : base(message)
        {
        }

        public IndexNotValid(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected IndexNotValid(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
