namespace Hakaton.Core
{
    public class Room : BaseEntity
    {
        public string Name { get; set; } = null!;

        public int HomeId { get; set; }
        public Home Home { get; set; } = null!;

        public ICollection<Device> Devices { get; set; } = null!;
    }
}
