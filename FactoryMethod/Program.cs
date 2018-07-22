using System;
using FactoryMethod.Concrete.Factory;
using FactoryMethod.Abstract;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal animal = null;

            Console.WriteLine("Select animal group \nReptiles , Mammals, Birds");
            string animalGroup = Console.ReadLine();

            if (!string.IsNullOrEmpty(animalGroup))
            {
                if (animalGroup == "Mammals")
                {
                    Console.WriteLine("Select which {0} you want to create Dog , Cat, Duck?", animalGroup);
                    string userChoice = Console.ReadLine();

                    var mammalsFactory = new MammalsFactory();
                    animal = mammalsFactory.CreateAnimal(userChoice);
                }
                else if (animalGroup == "Reptiles")
                {
                    Console.WriteLine("Select which {0} you want to create Dinosaurs, Snake?", animalGroup);
                    string userChoice = Console.ReadLine();
                    var reptilesFactory = new ReptilesFactory();
                    animal = reptilesFactory.CreateAnimal(userChoice);
                }
                else if (animalGroup == "Birds")
                {
                }
            }

            if (animal != null)
            {
                Console.WriteLine("Here is your animal " +
                                  "\nName: {0}" +
                                  "\nNoOfLegs: {1}" +
                                  "\nType: {2}" +
                                  "\nSound: {3}" +
                                  "\nRunning: {4}"
                    , animal.Name, animal.NoOfLegs, animal.Type, animal.MakeSound(), animal.Run());
            }
            else
            {
                Console.WriteLine("This animal group didnt exist in our system");
            }

            Console.ReadLine();
        }
    }
}
