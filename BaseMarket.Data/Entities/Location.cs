using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.Entities
{
    public class Location
    {
        public int LocationID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string NameWithType { get; set; }
        public string PathWithType { get; set; }
        public int ParentCode { get; set; }
        public int Levels { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string Slug { get; set; }
    }
}
