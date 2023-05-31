using System.Data;

namespace Hakaton.Core
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string PasswordSalt { get; set; } = null!;
        public Role Role { get; set; }
        public DateTime? LastSignInAt { get; set; }
        public bool IsVerified { get; set; }
        public bool IsActive { get; set; }
        public string? ProfilePhoto { get; set; }

        public ICollection<Home> Homes { get; set; } = null!;
        public ICollection<DeviceAction> DeviceActions { get; set; } = null!;
    }
}
