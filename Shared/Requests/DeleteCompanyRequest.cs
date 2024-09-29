using NServiceBus;
using System;

namespace Shared.Requests
{
    [Serializable]
    public class DeleteCompanyRequest : ICommand
    {
        public DeleteCompanyRequest(Guid companyId)
        {
            DataId = Guid.NewGuid();
            CompanyId = companyId;
        }

        public Guid DataId { get; set; }
        public Guid CompanyId { get; set; }
    }
}