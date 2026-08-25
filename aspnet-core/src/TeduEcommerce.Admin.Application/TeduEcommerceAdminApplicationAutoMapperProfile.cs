using AutoMapper;
using TeduEcommerce.Admin.ProductCategories;
using TeduEcommerce.Admin.Products;
using TeduEcommerce.ProductCategories;
using TeduEcommerce.Products;

namespace TeduEcommerce.Admin;

public class TeduEcommerceAdminApplicationAutoMapperProfile : Profile
{
    public TeduEcommerceAdminApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        //Product Category
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();
        CreateMap<CreateUpdateProductCategoryDto, ProductCategory>();

        //Product 
        CreateMap<Product, ProductDto>();
        CreateMap<ProductCategory, ProductInListDto>();
        CreateMap<CreateUpdateProductDto, ProductCategory>();

    }
}
