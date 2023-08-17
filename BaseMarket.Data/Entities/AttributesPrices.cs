using BaseMarket.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.Entities
{
    public class AttributesPrices
    {
        public int AttributesPriceID { get; set; }

        public int AttributeID { get; set; }

        public int ProductID { get; set; }
        public int Price { get; set; }
        public Active Active { get; set; }

        public Attributes Attributes { get; set; }

        public Product Product { get; set; }

    }
}
