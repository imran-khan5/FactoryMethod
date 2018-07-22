using FactoryMethod.Abstract;
using FactoryMethod.Concrete.Animals.Reptiles;

namespace FactoryMethod.Concrete.Factory
{
    public class ReptilesFactory : AnimalFactory
    {
        public override Animal CreateAnimal(string animalType)
        {
            if (animalType == "Dinosaur")
            {
                return new Dinosaur(type: animalType, name: "dino", noOfLegs: 2);
            }
            else
            {
                return null;
            }
        }
    }
}
