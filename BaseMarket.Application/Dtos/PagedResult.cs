using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Application.Dtos
{
    public class PagedResult <T>
    {
        public List<T> items { get; set; }
        public int TotalRecord { get; set; }
    }
}
