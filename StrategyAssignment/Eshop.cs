



using StrategyAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternSample
{
    class Eshop
    {
        public static void EShopDemo(decimal amount)
        {
            
            var basket = new EShopBasket();
            
            basket.SetDueAmount(amount);

            Console.Write("How would you like to pay? 1) Credit/Debit card, 2) Bank Transfer, 3) Cash : ");
            var paymentType = int.Parse(Console.ReadLine().Trim());

            Console.Write("Please select the shipment method : 1=PostOffice, 2=Courier, 3=Own, 4=Pickup:");
            var carrierType = (CarrierType)int.Parse(Console.ReadLine().Trim());

            Console.Write("Please give your address:");
            var address = Console.ReadLine().Trim();

            var simpleEshop = new SimpleEshop();
            var success = simpleEshop.PayAndSendOrder(basket, paymentType, address, carrierType);

            Console.Write("Is the address correct: ");
            Console.WriteLine(success);
            Console.WriteLine("Wou will soon receive a comfirmation email! Thank you for shopping with us!"
                );
            Console.WriteLine("Please press enter");
         
            Console.Read();
        }
    }

    // Facade
    class SimpleEshop
    {
        public bool PayAndSendOrder(EShopBasket basket, int paymentMethod, string address, CarrierType carrierType)
        {
            var payments = new Payments();
            bool success = payments.PayBasket(basket, paymentMethod);

            if (success)
            {
                if (carrierType != CarrierType.Pickup)
                {
                    var shipment = new Shipment();
                    if (shipment.CanShipTo(address, carrierType))
                    {
                        shipment.DeliverOrder(address, basket);
                    }
                    else
                    {
                        success = false;
                    }
                }
            }

            return success;
        }
    }

   
}



