using Strategy.TravelOptions;

namespace Strategy.TravelStrategies
{
  public interface ITravelStrategy
  {
    public ITravelOption FindBest(ITravelOption[] travelOptions);
  }
}
