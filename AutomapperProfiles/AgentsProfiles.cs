using AutoMapper;
using BasicApi.Controllers;
using BasicAPI.Data;

namespace BasicAPI.AutomapperProfiles
{
    public class AgentsProfiles : Profile
    {
        public AgentsProfiles()
        {
            //(Agent => AgentResponseItem)
            CreateMap<Agent, AgentResponseItem>();
            CreateMap<AgentCreateRequest, Agent>()
                .ForMember(dest => dest.State, options => options.MapFrom(src => src.StateCode))
                .ForMember(dest => dest.Retired, options => options.MapFrom(_ => false))
                .ForMember(dest => dest.Added, options => options.MapFrom(_ => DateTime.Now));
        }
    }
}
