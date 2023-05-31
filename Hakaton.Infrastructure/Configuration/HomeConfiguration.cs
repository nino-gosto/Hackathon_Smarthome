using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Hakaton.Core;

namespace Hakaton.Infrastructure
{
    public class HomeConfiguration : BaseConfiguration<Home>
    {
        public override void Configure(EntityTypeBuilder<Home> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.Name)
                   .IsRequired();

            builder.Property(e => e.Address)
                   .IsRequired();

            builder.Property(e => e.Type)
                   .IsRequired();

            builder.HasOne(d => d.User)
                .WithMany(d => d.Homes)
                .HasForeignKey(d => d.UserId)
                .IsRequired();
        }
    }
}

