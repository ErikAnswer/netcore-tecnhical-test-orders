using Core.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Common;

namespace Core.Messages.Commands
{
    public class CreateOrderCommand : DomainEvent, IRequest<Guid>
    {
        public Guid Id { get; set; }

        public IDictionary<string, decimal> Items { get; set; }
    }
}
