using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.TravelOptions
{
  public interface ITravelOption
  {
    int Cost { get; }
    int Time { get; }
  }
}
