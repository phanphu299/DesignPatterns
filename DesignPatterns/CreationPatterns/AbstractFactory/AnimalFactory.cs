namespace DesignPatterns.CreationPatterns.AbstractFactory
{
    internal abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(AnimalEnums animal);

        public static AnimalFactory GetAnimalFactory(FactoryEnums factory)
            => factory switch
            {
                FactoryEnums.SeaAnimal => new SeaAnimalFactory(),
                FactoryEnums.LandAnimal => new LandAnimalFactory(),
                _ => throw new NotImplementedException("Invalid Factory type!!!"),
            };
    }
}
