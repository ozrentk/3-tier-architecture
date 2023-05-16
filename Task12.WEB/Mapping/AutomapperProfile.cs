using AutoMapper;

namespace Task12.WEB.Mapping
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<BL.BLModels.BLUser, Viewmodels.VMUser>();
        }
    }
}
