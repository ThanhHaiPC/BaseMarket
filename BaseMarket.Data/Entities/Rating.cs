using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.Entities
{
    public class Rating
    {
        public int RatingID { get; set; }
        public int Stars { get; set; }
        public string Comment { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
