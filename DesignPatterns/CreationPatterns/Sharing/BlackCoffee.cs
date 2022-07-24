namespace DesignPatterns.CreationPatterns.Sharing
{
    internal class BlackCoffee : ICoffee
    {
        public string GetCoffeeType()
            => "This is BlackCoffee";

        public int GetCost()
            => 5;

        public int GetTip()
            => 1;
    }
}
