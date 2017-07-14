using System;

namespace Aquarium
{
  public class MenuBuilder
  {
    public int ShowMainMenu()
    {
      Console.Clear();
      Console.WriteLine("Welcome to Aquarium Builder!!!");
      Console.WriteLine("1. Add fish to aquarium");
      Console.WriteLine("2. Remove fish from aquarium");
      Console.WriteLine("3. Exit");
      ConsoleKeyInfo enteredKey = Console.ReadKey();
      Console.WriteLine("");
      return int.Parse(enteredKey.KeyChar.ToString());
    }
  }
}