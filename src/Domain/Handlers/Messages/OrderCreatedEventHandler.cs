using System.Threading;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Messages.Commands;
using Core.Messages.Events;
using Light.GuardClauses;
using MassTransit;
using MediatR;

namespace Core.Handlers.Messages
{
    public class OrderCreatedEventHandler : INotificationHandler<OrderCreatedEvent>
    {
        private readonly IBus _bus;

        public OrderCreatedEventHandler(IBus bus)
        {
            _bus = bus.MustNotBeDefault(nameof(bus));
        }

        public async Task Handle(OrderCreatedEvent notification, CancellationToken cancellationToken)
        {

            await _bus.Publish(notification, cancellationToken);
        }
    }



}
