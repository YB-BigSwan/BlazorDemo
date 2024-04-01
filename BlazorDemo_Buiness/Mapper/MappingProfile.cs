using AutoMapper;
using BlazorDemo.BlazorDemo_DataAccess;
using BlazorDemo.DemoModels;

namespace BlazorDemo.BlazorDemo_Buiness.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryDTO>().ReverseMap();
        CreateMap<Product, ProductDTO>().ReverseMap();
        CreateMap<ProductPrice, ProductPriceDTO>().ReverseMap();
    }
}