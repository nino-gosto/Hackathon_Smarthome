using Hakaton.Api;
using Hakaton.Core;

namespace Hakaton.Application
{
    public class UserProfile : BaseProfile
    {
        public UserProfile()
        {
            CreateMap<AccessSignUpModel, UserUpsertDto>()
                .ForMember(a => a.Role, o => o.MapFrom(s => Role.Parent));
        }
    }
}
