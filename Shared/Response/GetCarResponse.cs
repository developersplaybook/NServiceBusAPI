using NServiceBus;
using Shared.Models;
using System;

namespace Shared.Responses
{
    [Serializable]
    public class GetCarResponse : IMessage
    {
        public GetCarResponse()
        {
            DataId = Guid.NewGuid();
        }

        public Guid DataId { get; set; }
        public Car Car { get; set; }
    }
}