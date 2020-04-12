
using System;

namespace StrategyPatternSample
{
    // Order shipment subsystem
    class Shipment
    {
        public bool CanShipTo(string address, CarrierType carrier)
        {
            if (carrier == CarrierType.Pickup) return true;

            return !string.IsNullOrWhiteSpace(address);
        }

        public void DeliverOrder(string address, EShopBasket basket)
        {
            Console.WriteLine("Deliver order to address: " + address);
        }
    }

    enum CarrierType
    {
        PostOffice = 1,
        Courier = 2,
        OwnDelivery = 3,
        Pickup = 4
    }
}


