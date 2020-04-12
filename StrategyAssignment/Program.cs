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
    /// Application's goal : Supposed that it has received an wish list of a t-shirt, is calculates its price according to some variations, and let the customer pay, depending on his/hers chosen method

    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            // TODO add greek currency +++++++++++++++++++++++++++++++++++


            Eshop myEShop = new Eshop();
            TShirt sampleTshirt = new TShirt(Color.BLUE, Size.L, Fabric.CASHMERE);

            // Suppose a customer added a T-shirt to his wish list

            Console.WriteLine("Hello, you have chosen this beautiful t-shirt. Its details are:\n fabric : {0} , size : {1}, color : {2}", Fabric.CASHMERE.ToString().ToLower(), Size.L.ToString().ToLower(), Color.BLUE.ToString().ToLower());
            Console.WriteLine();

            //calculate the price of the tshirt
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("An authorized user sees these details: ");
            var amount = TotalTshirtCost.CalculateCost(sampleTshirt);
            Console.ForegroundColor = ConsoleColor.White;


            //Proceed to payment
            Console.WriteLine("I just made a change!");

            Console.WriteLine($"The total cost is {amount} Euro. Would you like to buy it now?");
            Console.WriteLine("------------");
            Console.WriteLine("| SHOP NOW |");
            Console.WriteLine("------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("We are proceeding to payment. ");
            Console.WriteLine();
            Console.WriteLine("Choose your prefered payment method.");
            Console.WriteLine();


            //Pay and type your shipment details
            Eshop.EShopDemo(amount);
           
            // Wait for user

            Console.ReadKey();

        }


    }



}
