using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.Entities
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Contents { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
