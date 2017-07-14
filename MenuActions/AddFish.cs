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
      a.AddFish(inventory[int.Parse(chosenFish.KeyChar.ToString()) - 1]);
    }
  }
}
