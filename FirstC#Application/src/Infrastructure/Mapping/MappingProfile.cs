using AutoMapper;
using FirstC_Application.src.Domain.Entities;

using FirstC_Application.src.Domain.Contract;
using static FirstC_Application.src.Domain.Contract.ProductsContract;


namespace FirstC_Application.src.Infrastructure.Mapping
    
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductResponse>();
            CreateMap<CreateProductRequest, Product>();
            CreateMap<UpdateProductRequest, Product>();
                

        }
    }
}
