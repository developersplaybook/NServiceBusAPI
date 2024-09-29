using NServiceBus;
using Shared.Models;
using System;

namespace Shared.Requests
{
    [Serializable]
    public class UpdateCarRequest : ICommand
    {
        public UpdateCarRequest(Car car)
        {
            DataId = Guid.NewGuid();
            Car = car;
        }

        public Guid DataId { get; set; }
        public Car Car { get; set; }
    }
}