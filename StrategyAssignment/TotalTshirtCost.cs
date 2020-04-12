using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment
{
    class TotalTshirtCost
    {
        public static decimal CommunicateWithCustomerAboutTshirt()
        {
            // Suppose a customer added a T-shirt to his wish list
            TShirt sampleTshirt = new TShirt(Color.BLUE, Size.L, Fabric.CASHMERE);
            ShowCustomerTshirtVariationDetails(sampleTshirt);

            //calculate the price of the tshirt
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("An authorized user sees these details: ");
            var amount = TotalTshirtCost.CalculateCost(sampleTshirt);
            Console.ForegroundColor = ConsoleColor.White;

            return amount;
        }

        //Communicate the details of the tshirt on the console
        private static void ShowCustomerTshirtVariationDetails(TShirt sampleTshirt)
        {
            Console.WriteLine();
            Console.WriteLine("Hello, you have chosen this beautiful t-shirt. Its details are : ");
            Console.WriteLine("Fabric : {0} , Size : {1}, Color : {2}", sampleTshirt.Fabric.ToString().ToLower(), sampleTshirt.Size.ToString().ToLower(), sampleTshirt.Color.ToString().ToLower());
            Console.WriteLine();
        }


        //Calculating the total cost of a T-shirt
        //Question to you, Teacher: Is it ok for this method to exist here? Where would you place it as a "best practise"? 
        //Would it better to be placed somewhere where it could remain Private? If so, where?
        // Also, how can this method be written in order to DRY? With a foreach, perhaps? If so, how could i bring all the variations in a list?

        private static decimal CalculateCost(TShirt tshirt)
        {
            VariationCost variationTotalCost;
            Console.WriteLine();

            //Three VariationTotalCosts following different strategies
            //Note : Shop customer-servise's view: 

            Console.WriteLine($"Cost before any variation is : { tshirt.Price }");

            variationTotalCost = new VariationCost(new FabricVariation());
            variationTotalCost.CalculateCostVariation(tshirt);
            Console.WriteLine("Cost after the {1} variation is : {0:c}", tshirt.Price, tshirt.Fabric.GetType().Name);

            variationTotalCost = new VariationCost(new SizeVariation());
            variationTotalCost.CalculateCostVariation(tshirt);
            Console.WriteLine("Cost after the  {1} variation is : {0:c}", tshirt.Price, tshirt.Fabric.GetType().Name);

            variationTotalCost = new VariationCost(new ColorVariation());
            variationTotalCost.CalculateCostVariation(tshirt);
            Console.WriteLine("Cost after the  {1} variation is : {0:c}", tshirt.Price, tshirt.Fabric.GetType().Name);
            Console.WriteLine();
            Console.WriteLine();


            return tshirt.Price;
        }
    }
}
