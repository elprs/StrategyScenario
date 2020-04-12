using StrategyAssignment;
using System;
using System.Threading;

namespace StrategyPatternSample
{
    public static class Eshop
    {
        //Find rhe cost, communicate all the tshirt and process details to the user

        public static decimal CostAndCommunication()
        {
            decimal amount = TotalTshirtCost.CommunicateWithCustomerAboutTshirt();
            ProceedToPaymentUserMessage(amount);
            return amount;
        }

        public static void EShopDemo(decimal amount)
        {
            var basket = new EShopBasket();

            basket.SetDueAmount(amount);

            Console.WriteLine("How would you like to pay? \n1) Credit/Debit card, \n2) Bank Transfer, \n3) Cash \nDefault: Cash ");
            var paymentType = 10;
            paymentType = ValidatingNumberTypeInput();
            ValidPaymentTypeCheck(paymentType);


            Console.WriteLine("Please select the shipment method : 1) PostOffice, 2) Courier, 3) Own, 4) Pickup:");
            var carrierType = (CarrierType)10;
            carrierType = (CarrierType)ValidatingNumberTypeInput();
            ValidCarrierTypeCheck(carrierType);
       
            Console.WriteLine();
           
            Console.WriteLine("Please give your address:");
            var address = Console.ReadLine().Trim();
            Console.WriteLine();

            ConfirmingAddress(basket, paymentType, carrierType, address);
        }

        //TODO refactor and generalize the below validations:  


        //Validation for the payment method

        private static void ValidPaymentTypeCheck(int paymentType)
        {
            if (!(paymentType > 3 || paymentType < 0))
            {
                Console.WriteLine($"The payment method {paymentType} was chosen.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The default value is applied");
                Console.WriteLine();
            }
        }

        //Validation for the carrier method

        private static void ValidCarrierTypeCheck(CarrierType carrierType)
        {
            if (!((int)carrierType > 4 || carrierType < 0))
            {
                Console.WriteLine($"The payment method {carrierType} was chosen.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The default value is applied");
                Console.WriteLine();
            }
        }

        //Try catch for the payment method

        private static int ValidatingNumberTypeInput()
        {
            bool success = false;
            int input = -1;


            //Checking if the user input is a number

            while (success == false)
            {
                try
                {
                    input = int.Parse(Console.ReadLine().Trim());
                    success = true;
                }
                catch (FormatException e)
                {

                    Console.WriteLine("Invalid input. Please type one of the option and press enter.");
                   
                    success = false;

                }
                catch (NullReferenceException e)
                {
                    
                    Console.WriteLine("No input. The default value is applied");
                    success = true;

                }
                catch (Exception e)
                {

                    Console.WriteLine("{0} Exception caught.", e);
                    success = false;

                }
                finally
                {
                    Console.WriteLine("Your request is processed.");
                }
            }

            return input;
        }

        //Messages to user

        private static void ConfirmingAddress(EShopBasket basket, int paymentType, CarrierType carrierType, string address)
        {
            var simpleEshop = new SimpleEshop();
            var success = simpleEshop.PayAndSendOrder(basket, paymentType, address, carrierType);

            Console.Write("Checking the address...");
            Console.Write("Checking with the system...  ");
            Console.WriteLine("Loading...  ");
            Thread.Sleep(2000);

            

            Console.WriteLine("Is the address correct?  ");
            Console.WriteLine(success);
            Console.WriteLine("Your order is complete!");
            Console.WriteLine();
            Console.WriteLine("Note that our future features you will be able to receive a comfirmation email with your order! \nThank you for shopping with us!");
            Console.WriteLine();
        }

        private static void ProceedToPaymentUserMessage(decimal amount)
        {
            //Proceed to payment

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



