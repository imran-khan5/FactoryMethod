using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete.Animals.Reptiles
{
    public class Dinosaur : Animal
    {
        public Dinosaur(string type, string name, int noOfLegs) : base(name, type, noOfLegs)
        {
        }

        public override string MakeSound()
        {
            return "boooohhaaaaa";
        }

        public override string Run()
        {
            return "fast";
        }
    }
}
