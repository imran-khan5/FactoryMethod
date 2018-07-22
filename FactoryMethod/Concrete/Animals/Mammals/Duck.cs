using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete.Animals.Mammals
{
    public class Duck : Animal
    {
        public Duck(string type, string name, int noOfLegs) : base(name, type, noOfLegs)
        {
        }

        public override string MakeSound()
        {
            return "quak quak";
        }

        public override string Run()
        {
            return "very slow";
        }

    }
}
