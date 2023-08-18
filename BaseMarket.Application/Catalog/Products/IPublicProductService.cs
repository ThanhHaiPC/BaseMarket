using BaseMarket.Application.Catalog.Products.DTOs;
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
        public  PagedViewModel<ProductViewModel> GetAllByCategaryID(int categaryID, int pageIndex, int pageSize);
    }
}
