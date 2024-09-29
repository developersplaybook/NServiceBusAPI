using NServiceBus;
using System;

namespace Shared.Requests
{
    [Serializable]
    public class GetCompaniesRequest : ICommand
    {
        public GetCompaniesRequest()
        {
            DataId = Guid.NewGuid();
        }

        public Guid DataId { get; set; }
    }
}
