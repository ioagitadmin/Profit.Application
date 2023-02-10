using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Profit.Domain.Models;

namespace Profit.Infrastructure.Database
{
    public class ModelConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(entity => entity.Id);
            builder.HasIndex(entity => entity.Id).IsUnique();
            builder.Property(entity => entity.Data).HasMaxLength(255);
        }
    }
}