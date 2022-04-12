using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Common;

namespace Core.Messages.Events
{
    public class OrderCreatedEvent: DomainEvent, INotification
    {
        public Guid Id { get; set; }

        public Guid Correlation { get; set; }

    }



}
