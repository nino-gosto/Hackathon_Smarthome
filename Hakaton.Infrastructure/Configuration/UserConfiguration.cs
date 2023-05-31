using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Hakaton.Core;

namespace Hakaton.Infrastructure
{
    public class UserConfiguration : BaseConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.FirstName)
                   .IsRequired();

            builder.Property(e => e.LastName)
                   .IsRequired();

            builder.Property(e => e.Email)
                   .IsRequired();

            builder.Property(e => e.PhoneNumber)
                   .IsRequired();

            builder.Property(e => e.PasswordHash)
                   .IsRequired();

            builder.Property(e => e.PasswordSalt)
                   .IsRequired();

            builder.Property(e => e.Role)
                   .IsRequired();

            builder.Property(e => e.LastSignInAt)
                   .IsRequired(false);

            builder.Property(e => e.IsVerified)
                   .IsRequired();

            builder.Property(e => e.IsActive)
                   .IsRequired();

        }
    }
}
