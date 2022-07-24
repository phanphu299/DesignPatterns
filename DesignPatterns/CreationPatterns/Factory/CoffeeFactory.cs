using DesignPatterns.CreationPatterns.Sharing;

namespace DesignPatterns.CreationPatterns.Factory
{
    // FACTORY DO THE BUSINESS
    internal static class CoffeeFactory
    {
        public static ICoffee GetCoffee(string coffeeType)
            => coffeeType switch
            {
                CoffeeTypeConsts.BlackCoffe => new BlackCoffee(),
                CoffeeTypeConsts.MilkCoffe => new MilkCoffee(),
                CoffeeTypeConsts.Mocha => new Mocha(),
                CoffeeTypeConsts.Cappuchino => new Cappuchino(),
                _ => throw new NotImplementedException("Invalid Coffee type!!!"),
            };
    }
}
