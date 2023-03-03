using AutoMapper;

namespace Challenge05.Frontend
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
            //CreateMap<Basket, BasketDTO>().ReverseMap();

        }
    }
}
