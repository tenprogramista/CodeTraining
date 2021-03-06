using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.TravelOptions
{
  class BikeTravel : ITravelOption
  {
    public int Cost => 0;
    public int Time => 5;
  }
}
