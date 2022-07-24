namespace DesignPatterns.CreationPatterns.Sharing
{
    internal class Cappuchino : ICoffee
    {
        public string GetCoffeeType()
            => "This is Cappuchino";

        public int GetCost()
            => 10;

        public int GetTip()
            => 1;
    }
}
