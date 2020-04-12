using StrategyPatternSample;
using System;
using System.Globalization;

namespace StrategyAssignment
{
    /// <summary>
    /// Entry point into console application.
    /// 
    /// Application's goal : 
    /// Supposed that a customer has a wish list of a t-shirt.
    /// The system calculates the t-shirt price according to its variations, and lets the customer pay depending on his/hers chosen payment method.
    /// 
    /// Eleni Parisi
    /// Stategy pattern istructor: Kostas Stroggylos
    /// 
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

            Console.WriteLine("Please press enter to continue");

            Console.Read();

        }
    }
}
