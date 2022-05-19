using AutoMapper;
using InnowiseTask.Server.Data.Models;
using InnowiseTask.Server.Data.Models.Dto;

namespace InnowiseTask.Server.Configurations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Fridge, FridgeDto>()
                .ForMember(f => f.FullName,
                opt => opt.MapFrom(r => string.Join(' ', r.Name, r.OwnerName)));
        }
    }
}
