namespace FactoryMethod.Abstract
{
    public abstract class AnimalFactory
    {
        public abstract Animal CreateAnimal(string animalType);
    }
}
