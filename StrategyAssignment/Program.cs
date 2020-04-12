using StrategyPatternSample;
using System;
using System.Globalization;

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
            //Greek globalization system

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("gr-GR");

            //Calculate Total cost and communicate the tshirt details with the user

            decimal amount = Eshop.CostAndCommunication();

            //Pay and type your shipment details

            Eshop.EShopDemo(amount);

            // Wait for user

            Console.ReadKey();

        }

       

    }



}
