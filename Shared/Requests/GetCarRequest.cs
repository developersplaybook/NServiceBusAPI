using NServiceBus;
using System;

namespace Shared.Requests
{
    [Serializable]
    public class GetCarRequest : ICommand
    {
        public GetCarRequest(Guid carId)
        {
            DataId = Guid.NewGuid();
            CarId = carId;
        }

        public Guid DataId { get; set; }
        public Guid CarId { get; set; }
    }
}
