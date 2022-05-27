using AutoMapper;
using InnowiseTask.Server.Data.Models;
using InnowiseTask.Server.Data.Models.Dto;
using System.Linq;

namespace InnowiseTask.Server.Configurations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Fridge, FridgeDto>()
                .ForMember(f => f.FullName,
                opt => opt.MapFrom(r => string.Join(' ', r.Name, r.OwnerName)));
            CreateMap<Product, ProductDto>();
                //.ForMember(p => p.Quantity,
                //opt => opt.MapFrom(src => src.FridgeProducts.Select(s => s.Quantity)));

        }
    }
}
