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
            Eshop myEShop = new Eshop();
            Console.WriteLine("Hello, our recommentation is this t-shirt");
            TShirt sampleTshirt = new TShirt(Color.BLUE, Size.L, Fabric.CASHMERE);
            Console.Write($"It costs { sampleTshirt.Price }");

            //Console.WriteLine("Please, create your own t-shirt");
            //TShirt customerTshirt;
            //Console.WriteLine("Choose a size: 1 = XS,2 = S, 3 = M, 4 = L, 5 = XL, 6 = XXL, 7 = XXXL");
            //string sizeChoice;  // add nullable option ++
            //sizeChoice = Console.ReadLine();

            //GetSize(customerTshirt, sizeChoice);
            //return;

            //myEShop.PayTShirt(customerTshirt);
            Console.Read();
        }

        //private static void GetSize(TShirt customerTshirt, string sizeChoice)
        //{
        //    switch (sizeChoice)
        //    {
        //        case 1:
        //            customerTshirt.Size = Size.XS;
        //            break; 
        //        case 2:customerTshirt.Size = Size.S;
        //            break; 
        //        case 4:customerTshirt.Size = Size.L;
        //            break; 
        //        case 5:customerTshirt.Size = Size.XL;
        //            break; 
        //        case 6:customerTshirt.Size = Size.XXL;
        //            break; 
        //        case 7:customerTshirt.Size = Size.XXXL;
        //            break;

        //        default:  customerTshirt.Size = Size.M;:
        //            break; 

        //    }
        //}
    }



    
}
