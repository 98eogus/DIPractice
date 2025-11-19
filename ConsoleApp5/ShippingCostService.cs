using ConsoleApp5.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class ShippingCostService
    {
        private readonly IShippingCostStrategy _strategy;

        public ShippingCostService(IShippingCostStrategy strategy)
        {
            _strategy = strategy;
        }

        public void PrintCost(int weight)
        {
            int cost = _strategy.Calculate(weight);
            Console.WriteLine($"배송비는 {cost}원입니다.");
        }
    }
}
