using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment
{
    class TShirt
    {
        public readonly Color Color;
        public readonly Size Size;
        public readonly Fabric Fabric;

        public decimal Price { get; set; }

        public TShirt(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }

        //Calculating the total cost of a T-shirt
        //Question to you, Teacher: Is it ok for this method to exist here? Where would you place it as a "best practise"? 
        //Would it better to be placed somewhere where it could remain Private? If so, where?

        public static void CalculatingTotalTshirtCost(TShirt sampleTshirt)
        {
            VariationCost variationTotalCost;
            Console.WriteLine();

            //Three VariationTotalCosts following different strategies
            //Note : Shop customer-servise's view: 

            Console.WriteLine($"It's cost before any variation is : { sampleTshirt.Price }");

            variationTotalCost = new VariationCost(new FabricVariation());
            variationTotalCost.CalculateCostOf(sampleTshirt);
            Console.WriteLine("It's cost after fabric variation is : {0:c}", sampleTshirt.Price);

            variationTotalCost = new VariationCost(new SizeVariation());
            variationTotalCost.CalculateCostOf(sampleTshirt);
            Console.WriteLine("It's cost after size variation is : {0:c}", sampleTshirt.Price);

            variationTotalCost = new VariationCost(new ColorVariation());
            variationTotalCost.CalculateCostOf(sampleTshirt);
            Console.WriteLine("It's cost after color variation is : {0:c}", sampleTshirt.Price);
            Console.WriteLine();
            Console.WriteLine();
        }


    }


    enum Color
    {
        RED,
        ORANGE,
        YELLOW,
        GREEN,
        BLUE,
        INDIGO,
        VIOLET
    }

    enum Size
    {
        XS,
        S,
        M,
        L,
        XL,
        XXL,
        XXXL
    }

    enum Fabric
    {
        WOOL,
        COTTON,
        POLYESTER,
        RAYON,
        LINEN,
        CASHMERE,
        SILK
    }


}
