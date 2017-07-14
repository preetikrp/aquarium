using System;
using System.Collections.Generic;
using Wildlife;

namespace Aquarium.MenuActions
{
  public class AddFish
  {
    public static void DoAction(FishStore s, Aquarium a)
    {
      Console.Clear();
      var inventory = s.Inventory;
      for (int i = 0; i < inventory.Count; i++)
      {
          Console.WriteLine($"{i+1}. {inventory[i].Name}");
      }
      Console.Write("> ");
      var chosenFish = Console.ReadKey();
      Console.WriteLine("");

      var keyPressed = chosenFish.KeyChar.ToString();
      var integerValueOfKeyPressed = int.Parse(keyPressed);
      var fishInInventory = inventory[integerValueOfKeyPressed - 1];

      a.AddFish(fishInInventory);
    }
  }
}
