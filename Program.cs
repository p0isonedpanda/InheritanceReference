using System;

namespace InheritanceReference
{
    class MainClass
    {
        class Animal
        {
            public string name;
            public int age;
            public float happiness;

            public void PrintBase ()
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Happiness: " + happiness);
                Console.WriteLine("---------------");
            }
        }

        class Dog : Animal
        {
            public int spotCount;
            
            public void Bark ()
            {
                Console.WriteLine("Woof!");
                happiness += 0.1f;
            }
        }

        class Cat : Animal
        {
            public float cuteness;
            
            public void Meow ()
            {
                Console.WriteLine("Meow!");
                happiness += 0.1f;
            }
        }

        public static void Main (string[] args)
        {
            Dog spotty = new Dog();
            spotty.name = "Spotty";
            spotty.age = 4;
            spotty.happiness = 0.8f;
            spotty.spotCount = 25;
            spotty.PrintBase();

            Console.WriteLine("Press enter for borks");
            Console.ReadKey();

            for (int i = 0; i < 10; i++)
            {
                spotty.Bark();
            }
            spotty.PrintBase();

            Console.WriteLine("Press enter for cat");
            Console.ReadKey();

            Cat heinsenberg = new Cat();
            heinsenberg.name = "Heisenberg";
            heinsenberg.age = 13;
            heinsenberg.happiness = 0.3f;
            heinsenberg.cuteness = 0.4f;
            heinsenberg.PrintBase();

            Console.WriteLine("Press enter for meows");
            Console.ReadKey();

            for (int i = 0; i < 10; i++)
            {
                heinsenberg.Meow();
            }
            heinsenberg.PrintBase();

            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }
    }
}