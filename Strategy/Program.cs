using Strategy.TravelStrategies;
using System;

namespace Strategy
{
  internal static class Program
  {
    private static void Main()
    {
      var context = new Context();

      Console.WriteLine("Setting Strategy to LowestCost");
      context.SetStrategy(new LowestCostStrategy());
      context.FindBestTravelOption();
      Console.WriteLine();

      Console.WriteLine("Setting Strategy to ShortestTravel");
      context.SetStrategy(new ShortestTravelStrategy());
      context.FindBestTravelOption();
      Console.WriteLine();

      Console.WriteLine("Setting Strategy to CostEfficient");
      context.SetStrategy(new CostEffectiveStrategy());
      context.FindBestTravelOption();
      Console.WriteLine();

      Console.WriteLine("Press Any Key to Quit");
      Console.ReadKey();
    }
  }
}
