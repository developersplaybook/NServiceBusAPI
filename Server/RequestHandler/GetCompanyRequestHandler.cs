using NServiceBus;
using NServiceBus.Logging;
using Server.Data;
using Shared.Requests;
using Shared.Responses;
using System.Threading.Tasks;

namespace Server.RequestHandlers
{
    public class GetCompanyRequestHandler : IHandleMessages<GetCompanyRequest>
    {
        readonly ICompanyRepository _companyRepository;

        public GetCompanyRequestHandler(ICompanyRepository caompanyRepository)
        {
            _companyRepository = caompanyRepository;
        }

        static ILog log = LogManager.GetLogger<GetCompanyRequest>();

        public async Task Handle(GetCompanyRequest message, IMessageHandlerContext context)
        {
            log.Info("Received GetCompanyRequest");

            var company = await _companyRepository.GetCompanyAsync(message.CompanyId);

            var response = new GetCompanyResponse()
            {
                DataId = message.DataId,
                Company = company
            };

            await context.Reply(response);
        }
    }
}