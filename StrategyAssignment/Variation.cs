using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment
{
    abstract class Variation
    {
        public abstract decimal Cost(TShirt tshirt);
    }

    class ColorVariation : Variation
    {
        public override decimal Cost(TShirt tshirt)
        {
            switch (tshirt.Color)
            {
                case Color.BLUE:
                    tshirt.Price += 0.5m;
                    break;

                case Color.GREEN:
                    tshirt.Price += 0.75m;
                    break;

                default:
                    tshirt.Price += 1.05m;
                    break;
            }

            return tshirt.Price;
        }
    }

}
