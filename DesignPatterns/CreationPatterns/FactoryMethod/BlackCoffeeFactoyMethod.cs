using DesignPatterns.CreationPatterns.Sharing;

namespace DesignPatterns.CreationPatterns.FactoryMethod
{
    internal class BlackCoffeeFactoyMethod : CoffeeFactoyMethod
    {
        protected override ICoffee MakeCoffee()
            => new BlackCoffee();
    }
}
