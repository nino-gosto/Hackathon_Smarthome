using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Hakaton.Core;

namespace Hakaton.Infrastructure
{
    public class RoomConfiguration : BaseConfiguration<Room>
    {
        public override void Configure(EntityTypeBuilder<Room> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.Name)
                   .IsRequired();

            builder.HasOne(d => d.Home)
                .WithMany(d => d.Rooms)
                .HasForeignKey(d => d.HomeId)
                .IsRequired();
        }
    }
}

