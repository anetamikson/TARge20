using System;

namespace CatsAndDogsOop
{
    class Program
    {

        class Pet
        {
            public string name;
            public string color;
            public int levelOfHappiness;

            public void PrintPetInfo()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Color: {color}");
                Console.WriteLine($"Level of happiness: {levelOfHappiness}");
            }
        }

        class Dog : Pet
        {
            public Dog(string _name, string _color)
            {
                name = _name;
                color = _color;
                levelOfHappiness = 0;
            }
            public void WaveTail()
            {
                levelOfHappiness += 1;
            }
            public bool Bark()
            {
                Console.WriteLine("Woof-woof");
                return true;
            }
        }

        class Cat : Pet
        {
            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                levelOfHappiness = 10;
            }

            public void HearTheDog()
            {
                levelOfHappiness = 0;
            }

            public void Hiss()
            {
                Console.WriteLine("Hissssss");
            }
        }
        static void Main(string[] args)
        {
            Dog dog = new Dog("Steffy", "Black and brown");
            dog.PrintPetInfo();
            Cat cat = new Cat("Kurri","Black and white");
            cat.PrintPetInfo();

            bool dogBarked = false;

            for (int i = 0; i < 10; i++)
            {
                dog.WaveTail();
            }
            dog.PrintPetInfo();

            if(dog.Bark())
            {
                cat.HearTheDog();
            }

            if (cat.levelOfHappiness == 0)
            {
                cat.Hiss();
            }
        }
    }
}
