using AutoMapper;
using InnowiseTask.Server.Data.Models;
using InnowiseTask.Server.Data.Models.Dto;
using System.Linq;

namespace InnowiseTask.Server.Configurations
{
    public  class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Fridge, FridgeDto>()
                .ForMember(f => f.FullName,
                opt => opt.MapFrom(r => string.Join(' ', r.Name, r.OwnerName)));
            CreateMap<Product, ProductDto>();
            CreateMap<FridgeToUpdateDto, Fridge>();
            CreateMap<FridgeProduct, FridgeProductDto>()
                .ForMember(p => p.ProductName,
                opt => opt.MapFrom(src => src.Product.Name))
                .ForMember(f => f.FridgeName,
                opt => opt.MapFrom(src => src.Fridge.Name));
        }

    }
}
