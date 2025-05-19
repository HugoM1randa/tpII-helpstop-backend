using AutoMapper;
using HelpApp.Application.DTOs;
using HelpApp.Domain.Entities;

namespace HelpApp.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile() 
        {
            CreateMap<Category, ProductDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
