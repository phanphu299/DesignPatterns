namespace DesignPatterns.CreationPatterns.AbstractFactory
{
    internal class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(AnimalEnums animal)
            => animal switch
            {
                AnimalEnums.Dog => new Dog(),
                AnimalEnums.Cat => new Cat(),
                AnimalEnums.Chicken => new Chicken(),
                _ => throw new NotImplementedException("Invalid Animal type!!!"),
            };
    }
}
