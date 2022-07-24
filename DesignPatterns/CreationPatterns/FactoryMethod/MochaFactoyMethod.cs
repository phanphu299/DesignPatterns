using DesignPatterns.CreationPatterns.Sharing;

namespace DesignPatterns.CreationPatterns.FactoryMethod
{
    internal class MochaFactoyMethod : CoffeeFactoyMethod
    {
        protected override ICoffee MakeCoffee()
            => new Mocha();
    }
}
