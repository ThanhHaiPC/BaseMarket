
using BaseMarket.ViewModels.Common;
using BaseMarket.ViewModels.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.ViewModels.Catalog.Products
{
    public interface IPublicProductService
    {
        Task <PagedResult<ProductViewModel>> GetAllByCategaryID(GetPublicProductPagingRequest request);
        Task <List<ProductViewModel>>GetAll();
    }
}
