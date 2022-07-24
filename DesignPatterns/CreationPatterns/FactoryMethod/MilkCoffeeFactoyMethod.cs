using DesignPatterns.CreationPatterns.Sharing;

namespace DesignPatterns.CreationPatterns.FactoryMethod
{
    internal class MilkCoffeeFactoyMethod : CoffeeFactoyMethod
    {
        protected override ICoffee MakeCoffee()
            => new MilkCoffee();
    }
}
