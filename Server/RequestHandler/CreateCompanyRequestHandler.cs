using NServiceBus;
using NServiceBus.Logging;
using Server.Data;
using Shared.Requests;
using Shared.Responses;
using System.Threading.Tasks;

namespace Server.RequestHandlers
{
    public class CreateCompanyRequestHandler : IHandleMessages<CreateCompanyRequest>
    {
        readonly ICompanyRepository _companyRepository;

        public CreateCompanyRequestHandler(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        static ILog log = LogManager.GetLogger<CreateCompanyRequest>();

        public async Task Handle(CreateCompanyRequest message, IMessageHandlerContext context)
        {
            log.Info("Received CreateCompanyRequest.");

            await _companyRepository.AddCompanyAsync(message.Company);

            var response = new CreateCompanyResponse()
            {
                DataId = message.DataId,
                Company = message.Company
            };

            await context.Reply(response);
        }
    }
}