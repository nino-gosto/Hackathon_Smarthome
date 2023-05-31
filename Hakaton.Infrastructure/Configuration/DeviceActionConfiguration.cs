using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Hakaton.Core;

namespace Hakaton.Infrastructure
{
    public class DeviceActionConfiguration : BaseConfiguration<DeviceAction>
    {
        public override void Configure(EntityTypeBuilder<DeviceAction> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.SettingName)
                   .IsRequired();

            builder.Property(e => e.StartTime)
                  .IsRequired();

            builder.Property(e => e.EndTime)
                  .IsRequired();

            builder.Property(e => e.SettingValue)
                  .IsRequired();

            builder.HasOne(d => d.Device)
                .WithMany(d => d.DeviceActions)
                .HasForeignKey(d => d.DeviceId)
                .IsRequired();

            builder.HasOne(d => d.User)
                .WithMany(d => d.DeviceActions)
                .HasForeignKey(d => d.UserId)
                .IsRequired();

        }
    }
}

