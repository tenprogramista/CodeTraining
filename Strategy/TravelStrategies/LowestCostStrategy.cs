using Strategy.TravelOptions;

namespace Strategy.TravelStrategies
{
  internal class LowestCostStrategy : ITravelStrategy
  {
    public ITravelOption FindBest(ITravelOption[] travelOptions)
    {
      int bestOptionId = -1;
      int bestCost = int.MaxValue;

      for (int i = 0; i < travelOptions.Length; i++)
      {
        if (travelOptions[i].Cost < bestCost)
        {
          bestCost = travelOptions[i].Cost;
          bestOptionId = i;
        }
      }

      return travelOptions[bestOptionId];
    }
  }
}
