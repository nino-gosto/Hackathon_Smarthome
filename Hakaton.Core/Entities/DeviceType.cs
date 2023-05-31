namespace Hakaton.Core
{
    public class DeviceType : BaseEntity
    {
        public string Name { get; set; } = null!;

        public ICollection<Device> Devices { get; set; } = null!;
    }
}
