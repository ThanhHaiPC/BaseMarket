using BaseMarket.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.ViewModels.Catalog.Products
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ShortDesc { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public BestSellers BestSellers { get; set; }
        public HomeFlag HomeFlag { get; set; }
        public Active Active { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Tags { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDes { get; set; }
        public string MetaKey { get; set; }
        public int UnitStock { get; set; }
    }

}
