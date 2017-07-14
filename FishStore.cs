using System;
using System.Collections.Generic;
using Wildlife;

namespace Aquarium
{
  public class FishStore
  {
    private List<Fish> _stock = new List<Fish>(){
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

    public List<Fish> Inventory
    { 
      get
      {
        return _stock;
      }
    }

    public void DisplayInventory()
    {
      for (int i = 0; i < _stock.Count; i++)
      {
          Console.WriteLine($"{i+1}. {_stock[i].Name}");
      }
    }

  }
}