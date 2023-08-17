using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.Entities
{
    public class Attributes
    {
        public int AttributeID { get; set; }
        public string Name { get; set; }
        public List<AttributesPrices> AttributesPrices { get; set; }
    }
}
