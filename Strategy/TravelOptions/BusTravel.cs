using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.TravelOptions
{
  class BusTravel : ITravelOption
  {
    public int Cost => 2;
    public int Time => 3;
  }
}
