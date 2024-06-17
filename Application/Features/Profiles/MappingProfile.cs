using Application.Features.Brands.Commands.Create;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Brand, CreateBrandCommand>().ReverseMap();
        }
    }
}
