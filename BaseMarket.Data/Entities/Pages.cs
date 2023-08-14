using BaseMarket.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.Entities
{
    public class Pages
    {
        public int PageID { get; set; }
        public string PageName { get; set; }
        public string Contents { get; set; }
        public string Image { get; set; }
        public Active Active { get; set; }
        public string Title { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDes { get; set; }
        public string MetaKey { get; set; }
        public string Alias { get; set; }
        public string DisplayOrder { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }


    }

}
