using BaseMarket.Application.Catalog.Products.DTOs;
using BaseMarket.Application.Catalog.Products.DTOs.Public;
using BaseMarket.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task <PagedResult<ProductViewModel>> GetAllByCategaryID(GetProductPagingRequest request);
    }
}
