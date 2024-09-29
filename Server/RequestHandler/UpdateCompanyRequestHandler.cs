using NServiceBus;
using NServiceBus.Logging;
using Server.Data;
using Shared.Requests;
using Shared.Responses;
using System.Threading.Tasks;

namespace Server.RequestHandlers
{
    public class UpdateCompanyRequestHandler : IHandleMessages<UpdateCompanyRequest>
    {
        readonly ICompanyRepository _companyRepository;

        public UpdateCompanyRequestHandler(ICompanyRepository caompanyRepository)
        {
            _companyRepository = caompanyRepository;
        }


        static ILog log = LogManager.GetLogger<UpdateCompanyRequest>();

        public async Task Handle(UpdateCompanyRequest message, IMessageHandlerContext context)
        {
            log.Info("Received UpdateCompanyRequest");

            await _companyRepository.UpdateCompanyAsync(message.Company);

            var response = new UpdateCompanyResponse()
            {
                DataId = message.DataId,
                Company = message.Company
            };

            await context.Reply(response);

        }
    }
}