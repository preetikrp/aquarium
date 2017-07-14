using System;
using Wildlife;
using System.Collections.Generic;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fish> availableFish = new List<Fish>(){
                new Fish("Redfish"),
                new Fish("Bluefish"),
                new Fish("Tuna"),
                new Fish("Sunfish"),
                new Fish("Betta"),
                new Fish("Goldfish"),
                new Fish("Clownfish"),
                new Fish("Puffer"),
                new Fish("Stonefish")
            };

            Aquarium myAquarium = new Aquarium();

            Console.WriteLine("Welcome to Aquarium Builder!!!");
            Console.WriteLine("1. Add fish to aquarium");
            Console.WriteLine("2. Remove fish from aquarium");
            Console.WriteLine("3. Exit");
            ConsoleKeyInfo enteredKey = Console.ReadKey();
            Console.WriteLine("\n\n");

            switch (enteredKey.KeyChar)
            {
                case '1':
                    int c = 0;
                    foreach (Fish fish in availableFish)
                    {
                        c++;
                        Console.WriteLine($"{c}. {fish.Name}");
                    }
                    string chosenFish = Console.ReadLine();
                    int index = int.Parse(chosenFish) - 1;

                    Fish actualChosenFish = availableFish[index];
                    myAquarium.AddFish(actualChosenFish);
                    break;
                case '2':
                    int x = 0;
                    foreach (Fish fish in myAquarium.ListFish())
                    {
                        x++;
                        Console.WriteLine($"{x}. {fish.Name}");
                    }

                    break;
                default:
                    break;

            }
        }
    }
}













