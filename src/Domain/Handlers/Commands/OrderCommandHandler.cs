using System;
using Core.Messages.Commands;
using Light.GuardClauses;
using MassTransit;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Core.Domain.Models;
using Core.Interfaces;
using Core.Messages.Events;

namespace Core.Handlers.Commands
{
    public class OrderCommandHandler : IRequestHandler<CreateOrderCommand, Guid>
    {
        private readonly IAppContext _context;

        private readonly IMediator _mediator;
        public OrderCommandHandler(
            IAppContext repo,
            IMediator mediator)
        {
            _context = repo.MustNotBeDefault();
            _mediator = mediator;
        }

        public async Task<Guid> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {

            var entity = new OrderAggregateRoot(request);

            await _context.OrdersAggregateRoots.AddAsync(entity, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Send(new OrderCreatedEvent(), cancellationToken);

            return entity.Id;

        }


    }
}
