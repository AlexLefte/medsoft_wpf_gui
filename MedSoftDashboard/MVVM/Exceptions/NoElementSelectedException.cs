using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MedSoftDashboard.MVVM.Model;

namespace MedSoftDashboard.MVVM.Exceptions
{
    public class NoElementSelectedException : Exception
    {
        public NoElementSelectedException(string message) : base(message)
        {

        }

        public NoElementSelectedException(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected NoElementSelectedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
