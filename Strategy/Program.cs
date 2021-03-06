using Strategy.Strategies;

namespace Strategy
{
  static class Program
  {
    static void Main(string[] args)
    {
      var context = new Context();

      context.SetStrategy(new CostEffectiveStrategy());
      context.FindBestTravelOption();

      context.SetStrategy(new LowestCostStrategy());
      context.FindBestTravelOption();

      context.SetStrategy(new QuickestRouteStrategy());
      context.FindBestTravelOption();
    }
  }
}
