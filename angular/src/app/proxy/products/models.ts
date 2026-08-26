import type { ProductType } from '../tedu-ecommerce/products/product-type.enum';
import type { EntityDto } from '@abp/ng.core';

export interface CreateUpdateProductDto {
  manufactureId?: string;
  name?: string;
  code?: string;
  slug?: string;
  productType: ProductType;
  sku?: string;
  sortOrder: number;
  visibility: boolean;
  isActive: boolean;
  categoryId?: string;
  seoMetaDescription?: string;
  description?: string;
  thumbnailPicture?: string;
}

export interface ProductDto {
  name?: string;
  code?: string;
  slug?: string;
  sortOder: number;
  coverPicture?: string;
  visibility: boolean;
  isActive: boolean;
  parentId?: string;
  seoMetaDescription?: string;
  id?: string;
}

export interface ProductInListDto extends EntityDto {
  manufactureId?: string;
  name?: string;
  code?: string;
  slug?: string;
  productType: ProductType;
  sku?: string;
  sortOrder: number;
  visibility: boolean;
  isActive: boolean;
  categoryId?: string;
  thumbnailPicture?: string;
}
