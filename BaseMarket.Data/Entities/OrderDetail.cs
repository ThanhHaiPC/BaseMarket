using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.Entities
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public int OrderNumber { get; set; }
        public int TotalPrice { get; set; }
        public DateTime ShipDate { get; set; }
        public int UnitPrice { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }

      
    }

}
