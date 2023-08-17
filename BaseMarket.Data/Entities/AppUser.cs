using BaseMarket.Data.Enum;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
      
        public string? Fullname { get; set; }
        public string Token { get; set; }
        public Active Active { get; set; }
        public string Address { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime LastLogin { get; set; }
        public string Avatar { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Distric { get; set; }
        public string Ward { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
        public Location Location { get; set; }
        public List<Rating> Ratings { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
