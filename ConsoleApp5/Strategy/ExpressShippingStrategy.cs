using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Strategy
{
    public class ExpressShippingStrategy : IShippingCostStrategy
    {
        public int Calculate(int weight)
        {
            return 6000 + weight * 20;
        }
    }
}
