namespace StrategyAssignment
{
    class TShirt // Note to myself: Product<TShirt> with use of abstract and generics : public static decimal CalculateCost(TShirt tshirt) 
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
