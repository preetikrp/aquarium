using System;
using System.Collections.Generic;
using Wildlife;

namespace Aquarium.MenuActions
{
  public class RemoveFish
  {
    public static void DoAction(Aquarium a)
    {
      Console.Clear();
      var inventory = a.ListFish();
      for (int i = 0; i < inventory.Count; i++)
      {
          Console.WriteLine($"{i+1}. {inventory[i].Name}");
      }
      Console.Write("> ");
      var chosenFish = Console.ReadKey();
      Console.WriteLine("");
      a.RemoveFish(inventory[int.Parse(chosenFish.KeyChar.ToString()) - 1]);
    }
  }
}