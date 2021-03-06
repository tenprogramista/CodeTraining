using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.TravelOptions
{
  class CarTravel : ITravelOption
  {
    public int Cost => 5;
    public int Time => 2;
  }
}
