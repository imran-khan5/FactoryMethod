using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete.Animals.Mammals
{
    public class Dog : Animal
    {
        public Dog(string type, string name, int noOfLegs) : base(name, type, noOfLegs)
        {
        }

        public override string MakeSound()
        {
            return "woof wooof";
        }

        public override string Run()
        {
            return "fast";
        }
    }
}
