using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Application.Catalog.Products.DTOs
{
    public class ProductCreateRequest
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
    }
}
