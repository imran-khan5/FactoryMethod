using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete.Animals.Mammals
{
    public class Cat : Animal
    {

        public Cat(string type, string name, int noOfLegs) : base(name, type, noOfLegs)
        {
        }

        public override string MakeSound()
        {
            return "miaoooon";
        }

        public override string Run()
        {
            return "very fast";
        }
    }
}
