using DesignPatterns.CreationPatterns.Sharing;

namespace DesignPatterns.CreationPatterns.FactoryMethod
{
    internal abstract class CoffeeFactoyMethod
    {
        protected abstract ICoffee MakeCoffee();

        public ICoffee CreateCoffee()
            => MakeCoffee();
    }
}
