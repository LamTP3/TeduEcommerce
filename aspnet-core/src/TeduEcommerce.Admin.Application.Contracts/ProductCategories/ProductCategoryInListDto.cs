using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace TeduEcommerce.Admin.ProductCategories
{
    public class ProductCategoryInListDto : EntityDto
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public string Slug { get; set; }

        public int SortOder { get; set; }

        public string CoverPicture { get; set; }

        public bool Visibility { get; set; }

    }
}
