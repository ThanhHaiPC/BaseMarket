using BaseMarket.Application.Catalog.Products.DTOs;
using BaseMarket.Application.Catalog.Products.DTOs.Manage;
using BaseMarket.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int ProductID);
        Task<bool> UpdatePrice(int ProductID, int Price);
        Task<bool> UpdateUnitStock(int ProductID, int Quantity);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }
}
