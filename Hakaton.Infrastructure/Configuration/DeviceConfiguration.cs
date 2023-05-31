using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Hakaton.Core;

namespace Hakaton.Infrastructure
{
    public class DeviceConfiguration : BaseConfiguration<Device>
    {
        public override void Configure(EntityTypeBuilder<Device> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.Description)
                   .IsRequired();

            builder.Property(e => e.DevicePhoto)
                   .IsRequired(false);

            builder.HasOne(d => d.DeviceType)
                .WithMany(d => d.Devices)
                .HasForeignKey(d => d.DeviceTypeId)
                .IsRequired();

            builder.HasOne(d => d.Room)
                .WithMany(d => d.Devices)
                .HasForeignKey(d => d.RoomId)
                .IsRequired();
        }
    }
}
