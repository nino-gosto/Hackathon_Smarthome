namespace Hakaton.Common.Services
{
    public interface IEnumsService
    {
        Task<IEnumerable<KeyValuePair<int, string>>> GetHomesTypesAsync();
        Task<IEnumerable<KeyValuePair<int, string>>> GetRolesAsync();
    }
}
