using StrategyPatternSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment
{
    /// <summary>

    /// Entry point into console application.

    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            // TODO add greek currency +++++++++++++++++++++++++++++++++++


            Eshop myEShop = new Eshop();

            // Suggest a T-shirt to the customer

            Console.WriteLine("Hello, let us recomment you this beautiful t-shirt. Its details are:\n fabric : {0} , size : {1}, color : {2}", Fabric.CASHMERE.ToString().ToLower(), Size.L.ToString().ToLower(), Color.BLUE.ToString().ToLower());


            TShirt sampleTshirt = new TShirt(Color.BLUE, Size.L, Fabric.CASHMERE);
            
            // Calculating the price of the suggested item

            TShirt.CalculatingTotalTshirtCost(sampleTshirt);
            Console.WriteLine($"The total cost is {sampleTshirt.Price} Euro. Would you like to buy it now?");
            Console.WriteLine("------------");
            Console.WriteLine("| SHOP NOW |");
            Console.WriteLine("------------");

            Console.WriteLine("Let's proceed to the payment. ");

            Console.WriteLine("Choose your prefered payment method");


            //TODO Pay Shirt ... 3 pay options ++++++++++++++++++++++++ 



            // Wait for user

            Console.ReadKey();



          

            //Console.WriteLine("Please, create your own t-shirt");
            //TShirt customerTshirt;
            //Console.WriteLine("Choose a size: 1 = XS,2 = S, 3 = M, 4 = L, 5 = XL, 6 = XXL, 7 = XXXL");
            //string sizeChoice;  // add nullable option ++
            //sizeChoice = Console.ReadLine();

          

            //myEShop.PayTShirt(customerTshirt);
            Console.Read();
        }


    }



}
