using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Hakaton.Core;

namespace Hakaton.Infrastructure
{
    public class DeviceTypeConfiguration : BaseConfiguration<DeviceType>
    {
        public override void Configure(EntityTypeBuilder<DeviceType> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.Name)
                   .IsRequired();
        }
    }
}

