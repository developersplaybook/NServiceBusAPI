using NServiceBus;
using NServiceBus.Logging;
using Server.Data;
using Shared.Requests;
using Shared.Responses;
using System.Linq;
using System.Threading.Tasks;

namespace Server.RequestHandlers
{
    public class GetCarsRequestHandler : IHandleMessages<GetCarsRequest>
    {
        readonly ICarRepository _carRepository;

        public GetCarsRequestHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        static ILog log = LogManager.GetLogger<GetCarsRequestHandler>();

        public async Task Handle(GetCarsRequest message, IMessageHandlerContext context)
        {
            log.Info("Received GetCarsRequest.");

            var cars = await _carRepository.GetAllCarsAsync();

            var response = new GetCarsResponse()
            {
                DataId = message.DataId,
                Cars = cars.ToList()
            };

            await context.Reply(response);
        }
    }
}