using BaseMarket.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.Entities
{
    public class Posts
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public string Image { get; set; }
        public Active Active { get; set; }
        public string Alias { get; set; }
        public string Author { get; set; }
        public string Tags { get; set; }
        public isHot isHot { get; set; }
        public isNewfeed isNewfeed { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDes { get; set; }
        public string MetaKey { get; set; }
        public int Views { get; set; }
    }
}
