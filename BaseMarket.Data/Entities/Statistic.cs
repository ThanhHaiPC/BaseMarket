using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Data.Entities
{
    public class Statistic
    {
        public int StatisticID { get; set; }
        public DateTime Date { get; set; }
        public int TotalProducts { get; set; }
        public int TotalOrders { get; set; }
        public int TotalRevenue { get; set; }
        public int TotalProfit { get; set; }


    }
}
