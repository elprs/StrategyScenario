using System.Collections.Generic;

namespace StrategyAssignment
{
    abstract class Variation
    {
        public abstract decimal Cost(TShirt tshirt);
    }

    //abstract class Variation<T>
    //{
    //    public abstract decimal Cost<T>(T item);
    //}

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

    class SizeVariation : Variation
    {
        private static Dictionary<Size, decimal> _sizeCosts;

        static SizeVariation()
        {
            _sizeCosts = new Dictionary<Size, decimal>()
            {
                { Size.XS, -1m },
                { Size.S, -0.5m },
                { Size.M, 0m },
                { Size.L, 0.5m },
                { Size.XL, 1m },
                { Size.XXL, 2m },
                { Size.XXXL, 3.5m }
            };
        }

        public override decimal Cost(TShirt tshirt)
        {
            tshirt.Price += _sizeCosts[tshirt.Size];
            return tshirt.Price;
        }
    }

    class FabricVariation : Variation
    {
        private static Dictionary<Fabric, decimal> _fabricVariations;

        static FabricVariation()
        {
            _fabricVariations = new Dictionary<Fabric, decimal>()
            {
                { Fabric.CASHMERE, 15m },
                { Fabric.COTTON, 5m },
                { Fabric.LINEN, 9m },
                { Fabric.POLYESTER, 6m },
                { Fabric.RAYON, 8m },
                { Fabric.SILK, 22m },
                { Fabric.WOOL, 12m }
            };
        }

        public override decimal Cost(TShirt tshirt)
        {
            tshirt.Price += _fabricVariations[tshirt.Fabric];
            return tshirt.Price;
        }
    }
}
