using BaseMarket.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int ParentID { get; set; }
        public int Levels { get; set; }
        public Active Active { get; set; }
        public int DisplayOrder { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDes { get; set; }
        public string MetaKey { get; set; }
        public string SchemaMarkup { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
