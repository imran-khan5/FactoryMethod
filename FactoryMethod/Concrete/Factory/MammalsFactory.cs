using FactoryMethod.Abstract;
using FactoryMethod.Concrete.Animals.Mammals;

namespace FactoryMethod.Concrete.Factory
{
    public class MammalsFactory : AnimalFactory
    {
        public override Animal CreateAnimal(string animalType)
        {
            if (animalType == "Cat")
            {
                return new Cat(type: animalType, name: "kitty", noOfLegs: 4);
            }
            else if (animalType == "Dog")
            {
                return new Dog(type: animalType, name: "Tommy", noOfLegs: 4);
            }
            else if (animalType == "Duck")
            {
                return new Duck(type: animalType, name: "quacky", noOfLegs: 2);
            }
            else
            {
                return null;
            }
        }
    }
}
