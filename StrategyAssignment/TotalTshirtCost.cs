using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment
{
    class TotalTshirtCost
    {
        //Calculating the total cost of a T-shirt
        //Question to you, Teacher: Is it ok for this method to exist here? Where would you place it as a "best practise"? 
        //Would it better to be placed somewhere where it could remain Private? If so, where?
        // Also, how can this method be written in order to DRY? With a foreach, perhaps? ++

        public static decimal CalculateCost(TShirt tshirt)
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
