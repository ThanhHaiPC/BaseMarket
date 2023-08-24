using BaseMarket.ViewModels.Catalog.Products.Manage;
using BaseMarket.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.ViewModels.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int ProductID);
        Task<bool> UpdatePrice(int ProductID, int Price);
        Task<bool> UpdateUnitStock(int ProductID, int Quantity);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
        Task<int> AddImages(int ProductID, List <IFormFile> images);
        Task<int> RemoveImages(int ImageId);
        Task<int> UpdateImages(int ImageId);
        Task<List<ProductImageViewModel>> GetListImage(int ProductID);
    }
}
