using Strategy.TravelOptions;

namespace Strategy.TravelStrategies
{
  internal class CostEffectiveStrategy : ITravelStrategy
  {
    public ITravelOption FindBest(ITravelOption[] travelOptions)
    {
      int bestOptionId = -1;
      int bestScore = int.MaxValue;

      for (int i = 0; i < travelOptions.Length; i++)
      {
        int optionScore = travelOptions[i].Cost + travelOptions[i].Time;

        if (optionScore < bestScore)
        {
          bestScore = optionScore;
          bestOptionId = i;
        }
      }

      return travelOptions[bestOptionId];
    }
  }
}
