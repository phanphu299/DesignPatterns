namespace DesignPatterns.CreationPatterns.Sharing
{
    internal class Mocha : ICoffee
    {
        public string GetCoffeeType()
            => "This is Mocha";

        public int GetCost()
            => 8;

        public int GetTip()
            => 5;
    }
}
