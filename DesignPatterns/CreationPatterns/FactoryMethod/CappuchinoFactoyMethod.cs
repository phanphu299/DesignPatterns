using DesignPatterns.CreationPatterns.Sharing;

namespace DesignPatterns.CreationPatterns.FactoryMethod
{
    internal class CappuchinoFactoyMethod : CoffeeFactoyMethod
    {
        protected override ICoffee MakeCoffee()
            => new Cappuchino();
    }
}
