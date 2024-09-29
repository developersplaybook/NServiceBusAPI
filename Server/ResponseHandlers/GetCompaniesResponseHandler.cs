using NServiceBus;
using NServiceBus.Logging;
using Shared.Responses;
using System.Threading.Tasks;

namespace Server.ResponseHandlers
{
    public class GetCompaniesResponseHandler : IHandleMessages<GetCompaniesResponse>
    {
        static ILog log = LogManager.GetLogger<GetCompaniesResponse>();

        public Task Handle(GetCompaniesResponse message, IMessageHandlerContext context)
        {
            log.Info("Received GetCompaniesResponse");
            return Task.CompletedTask;
        }
    }
}