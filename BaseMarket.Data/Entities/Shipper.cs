using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.Entities
{
    public class Shipper
    {
        public int ShipperID { get; set; }
        public string ShipperName { get; set; }
        public string Phone { get; set; }
        public string ContactPerson { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public DateTime ShipDate { get; set; }

    }
}
