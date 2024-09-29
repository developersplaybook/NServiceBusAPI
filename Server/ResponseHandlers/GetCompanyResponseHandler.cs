using NServiceBus;
using NServiceBus.Logging;
using Shared.Responses;
using System.Threading.Tasks;

namespace Server.ResponseHandlers
{
    public class GetCompanyResponseHandler : IHandleMessages<GetCompanyResponse>
    {
        static ILog log = LogManager.GetLogger<GetCompanyResponse>();

        public Task Handle(GetCompanyResponse message, IMessageHandlerContext context)
        {
            log.Info("Received GetCompanyResponse");
            return Task.CompletedTask;
        }
    }
}