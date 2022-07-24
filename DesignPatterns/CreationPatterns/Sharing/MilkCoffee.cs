namespace DesignPatterns.CreationPatterns.Sharing
{
    internal class MilkCoffee : ICoffee
    {
        public string GetCoffeeType()
            => "This is MilkCoffee";

        public int GetCost()
            => 12;

        public int GetTip()
            => 2;
    }
}
