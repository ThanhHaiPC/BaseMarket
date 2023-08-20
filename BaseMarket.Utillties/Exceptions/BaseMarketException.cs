using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMarket.Utillties.Exceptions
{ 
        public class BaseMarketException : Exception
        {
            public BaseMarketException()
            {
            }

            public BaseMarketException(string message)
                : base(message)
            {
            }

            public BaseMarketException(string message, Exception inner)
                : base(message, inner)
            {
            }
        }
}

