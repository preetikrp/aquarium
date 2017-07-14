using System;
using Wildlife;
using System.Collections.Generic;

namespace Aquarium
{
  public class Aquarium
  {
    public string Name { get; set; }

    private List<Fish> _myFish = new List<Fish>();

    public void AddFish(Fish fish)
    {
      _myFish.Add(fish);
    }

    public void RemoveFish(Fish fish)
    {
      _myFish.Remove(fish);
    }

    public List<Fish> ListFish()
    {
      return _myFish;
    }

  }
}