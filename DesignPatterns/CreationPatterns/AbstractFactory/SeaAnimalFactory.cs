namespace DesignPatterns.CreationPatterns.AbstractFactory
{
    internal class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(AnimalEnums animal)
            => animal switch
            {
                AnimalEnums.Shark => new Shark(),
                AnimalEnums.Frog => new Frog(),
                _ => throw new NotImplementedException("Invalid Animal type!!!"),
            };
    }
}
