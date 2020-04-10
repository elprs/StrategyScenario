using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Eshop
    {
        //private PaymentMethod _paymentMethod;

        private IEnumerable<Variation> _variations;

        public void PayTShirt(TShirt tshirt)
        {
            foreach (var variation in _variations)
            {
                Console.WriteLine($"Applying {variation.GetType().Name}");
                variation.Cost(tshirt);
                Console.WriteLine($"TShirt cost after applying {variation.GetType().Name} is: {tshirt.Price}");
            }

            //_paymentMethod.Pay(tshirt.Price);
        }

    }
}
