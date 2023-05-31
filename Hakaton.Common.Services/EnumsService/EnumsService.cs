using Hakaton.Core;

namespace Hakaton.Common.Services
{
    public class EnumsService : IEnumsService
    {
        public Task<IEnumerable<KeyValuePair<int, string>>> GetHomesTypesAsync() => Task.FromResult(GetValues<HomeType>());
       
        public Task<IEnumerable<KeyValuePair<int, string>>> GetRolesAsync() => Task.FromResult(GetValues<Role>());

        private IEnumerable<KeyValuePair<int, string>> GetValues<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T))
                       .Cast<int>()
                       .Select(e => new KeyValuePair<int, string>(e, Enum.GetName(typeof(T), e)!));
        }
    }
}