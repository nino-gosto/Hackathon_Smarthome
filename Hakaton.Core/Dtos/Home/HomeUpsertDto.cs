namespace Hakaton.Core
{
    public class HomeUpsertDto : BaseUpsertDto
    {
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public HomeType Type { get; set; }

        public int UserId { get; set; }
    }
}
