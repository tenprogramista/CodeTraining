using Strategy.TravelOptions;
using Strategy.TravelStrategies;
using System;

namespace Strategy
{
  internal class Context
  {
    private ITravelStrategy _strategy;

    internal Context() { }

    internal Context(ITravelStrategy strategy)
    {
      _strategy = strategy;
    }

    internal void SetStrategy(ITravelStrategy strategy)
    {
      _strategy = strategy;
    }

    internal void FindBestTravelOption()
    {
      ITravelOption[] travelOptions = {
        new BikeTravel(),
        new BusTravel(),
        new CarTravel(),
        new OnFootTravel()
      };

      ITravelOption bestOption = _strategy.FindBest(travelOptions);

      Console.WriteLine($"The best is {ExtractTravelOptionName(bestOption)}!");
    }

    private string ExtractTravelOptionName(ITravelOption option)
    {
      return option.GetType().ToString().Split('.')[2];
    }
  }
}
