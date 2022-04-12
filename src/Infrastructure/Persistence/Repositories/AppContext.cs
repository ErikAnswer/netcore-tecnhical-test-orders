using Core.Messages.Events;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using Dapper;
using System.Threading.Tasks;
using Core.Common;
using Core.Domain.Models;
using Core.Interfaces;
using Core.Messages.Commands;
using MassTransit;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Persistence.Repositories
{
    public class AppContext : DbContext, IAppContext
    {

        public DbSet<OrderAggregateRoot> OrdersAggregateRoots { get; set; }

      
    };


}
