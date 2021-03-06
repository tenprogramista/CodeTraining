using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.TravelOptions
{
  interface ITravelOption
  {
    int Cost { get; }
    int Time { get; }
  }
}
