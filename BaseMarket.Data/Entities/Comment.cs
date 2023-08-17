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

        public int PostID { get; set; }

        public Guid UserID { get; set; }
        public string Contents { get; set; }
        public DateTime CreateDate { get; set; }

        public Posts Posts { get; set; }

        public AppUser AppUser { get; set; }
    }
}
