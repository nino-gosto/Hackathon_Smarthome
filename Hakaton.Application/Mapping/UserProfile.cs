using Hakaton.Core;

namespace Hakaton.Application
{
    public class UserProfile : BaseProfile
    {
        public UserProfile()
        {
            CreateMap<UserDto, User>().ReverseMap();

            CreateMap<User, UserSensitiveDto>();

            CreateMap<UserUpsertDto, User>()
                .ForMember(u => u.IsActive, o => o.MapFrom(_ => true))
                .ForMember(u => u.IsVerified, o => o.MapFrom(_ => true));
        }
    }
}
