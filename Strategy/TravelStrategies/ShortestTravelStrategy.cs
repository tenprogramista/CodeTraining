using Strategy.TravelOptions;

namespace Strategy.TravelStrategies
{
  class ShortestTravelStrategy : ITravelStrategy
  {
    public ITravelOption FindBest(ITravelOption[] travelOptions)
    {
      int bestOptionId = -1;
      int bestCost = int.MaxValue;

      for (int i = 0; i < travelOptions.Length; i++)
      {
        if (travelOptions[i].Time < bestCost)
        {
          bestCost = travelOptions[i].Time;
          bestOptionId = i;
        }
      }

      return travelOptions[bestOptionId];
    }
  }
}
