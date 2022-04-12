using Core.Messages.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Common;

namespace Core.Domain.Models
{
    public class OrderAggregateRoot : IDomainEvent
    {
        public Guid Id { get; set; }

        public IDictionary<string, decimal> Items { get; set; }

        public List<DomainEvent> DomainEvents { get; set; } = new List<DomainEvent>();

        public OrderAggregateRoot(CreateOrderCommand command)
        {
            this.Apply(command);
        }

        private void Apply(CreateOrderCommand command)
        {
            this.DomainEvents.Add(command);

            this.Id = command.Id;
            this.Items = command.Items;
            
        }


    }
}
