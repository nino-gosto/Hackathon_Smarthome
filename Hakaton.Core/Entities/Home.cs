namespace Hakaton.Core
{
    public class Home : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public HomeType Type { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public ICollection<Room> Rooms { get; set; } = null!;
    }
}
