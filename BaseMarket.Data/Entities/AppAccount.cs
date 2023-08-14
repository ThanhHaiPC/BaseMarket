using BaseMarket.Data.Enum;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.Entities
{
    public class AppAccount : IdentityUser<Guid>
    {
        public string? Fullname { get; set; }
        public string Token { get; set; }
        public Active Active { get; set; }
        public string Address { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
