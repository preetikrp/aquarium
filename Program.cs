using System;
using Wildlife;
using Aquarium.MenuActions;
using System.Collections.Generic;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the fish store instance
            FishStore store = new FishStore();

            // Create the aquarium that will hold purchased fish
            Aquarium myAquarium = new Aquarium();

            // Create the main menu builder
            MenuBuilder menu = new MenuBuilder();

            // Choice will hold the number entered by the user
            // after main menu ws displayed
            int choice;

            do
            {
                // Show the main menu
                choice = menu.ShowMainMenu();

                switch (choice)
                {
                    // Menu option 1: Adding fish
                    case 1:
                        AddFish.DoAction(store, myAquarium);
                        break;

                    // Menu option 2: Removing fish
                    case 2:
                        RemoveFish.DoAction(myAquarium);
                        break;
                }
            } while (choice != 3);
        }
    }
}
