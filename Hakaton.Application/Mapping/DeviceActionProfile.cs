using Hakaton.Core;

namespace Hakaton.Application
{
    public class DeviceActionProfile : BaseProfile
    {
        public DeviceActionProfile()
        {
            CreateMap<DeviceActionDto, DeviceAction>().ReverseMap();

            CreateMap<DeviceActionUpsertDto, DeviceAction>();
        }
    }
}
