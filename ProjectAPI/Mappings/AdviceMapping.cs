using AutoMapper;
using ProjectAPI.Dtos;
using ProjectAPI.Model;

namespace ProjectAPI.Mappings
{
    public class AdviceMapping: Profile
    {
        public AdviceMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<AdviceResponse, AdviceModel>();
            CreateMap<AdviceModel, AdviceResponse>();
        }
    }
}