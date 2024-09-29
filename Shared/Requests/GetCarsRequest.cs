using NServiceBus;
using System;

namespace Shared.Requests
{
    [Serializable]
    public class GetCarsRequest : ICommand
    {
        public GetCarsRequest()
        {
            DataId = Guid.NewGuid();
        }

        public Guid DataId { get; set; }
    }
}
