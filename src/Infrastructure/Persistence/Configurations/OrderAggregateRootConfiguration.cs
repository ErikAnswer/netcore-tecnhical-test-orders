using Core.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class OrderAggregateRootConfiguration : IEntityTypeConfiguration<OrderAggregateRoot>
{
    public void Configure(EntityTypeBuilder<OrderAggregateRoot> builder)
    {
        builder.Ignore(e => e.DomainEvents);

        builder.HasKey(t => t.Id);

        builder.Property(t => t.Id).IsRequired();
    }
}
