using BaseMarket.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public Deleted Deleted { get; set; }
        public Paid Paid { get; set; }
        public DateTime PaymentDate { get; set; }
        public string ShippingAddress { get; set; }
        public string Note { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
