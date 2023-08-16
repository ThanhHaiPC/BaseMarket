using BaseMarket.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public int LocationID { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Avatar { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Distric { get; set; }
        public string Ward { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public Active Active { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime LastLogin { get; set; }

        public Location Location { get; set; }
    }
}
