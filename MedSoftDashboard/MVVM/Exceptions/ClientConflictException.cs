using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MedSoftDashboard.MVVM.Model;

namespace MedSoftDashboard.MVVM.Exceptions
{
    public class ClientConflictException : Exception
    {
        public Client ExistingClient { get; }

        public Client ConflictingClient { get; }

        public ClientConflictException(Client existingClient, Client conflictingClient)
        {
            ExistingClient = existingClient;
            ConflictingClient = conflictingClient;
        }

        public ClientConflictException(string message, Client existingClient, Client conflictingClient) : base(message)
        {
            ExistingClient = existingClient;
            ConflictingClient = conflictingClient;
        }

        public ClientConflictException(string message, Exception innerException, Client existingClient, Client conflictingClient) : base(message, innerException)
        {
            ExistingClient = existingClient;
            ConflictingClient = conflictingClient;
        }

        protected ClientConflictException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
