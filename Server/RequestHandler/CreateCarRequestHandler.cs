using NServiceBus;
using NServiceBus.Logging;
using Server.Data;
using Shared.Requests;
using Shared.Responses;
using System.Threading.Tasks;

namespace Server.RequestHandlers
{
    public class CreateCarRequestHandler : IHandleMessages<CreateCarRequest>
    {
        readonly ICarRepository _carRepository;

        public CreateCarRequestHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        static ILog log = LogManager.GetLogger<CreateCarRequestHandler>();

        public async Task Handle(CreateCarRequest message, IMessageHandlerContext context)
        {
            log.Info("Received CreateCarRequest.");

            await _carRepository.AddCarAsync(message.Car);

            var response = new CreateCarResponse()
            {
                DataId = message.DataId,
                Car = message.Car
            };

            await context.Reply(response);
        }
    }
}