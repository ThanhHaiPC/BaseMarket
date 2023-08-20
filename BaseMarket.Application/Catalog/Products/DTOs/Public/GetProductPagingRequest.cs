using BaseMarket.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Application.Catalog.Products.DTOs.Public
{
    public class GetProductPagingRequest: PagingRequestBase
    {
        public int? CategoryID { get; set; }
    }
}
