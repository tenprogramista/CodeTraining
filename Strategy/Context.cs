using Strategy.Strategies;

namespace Strategy
{
  class Context
  {
    private IStrategy _strategy;

    internal Context() { }

    internal Context(IStrategy strategy)
    {
      _strategy = strategy;
    }

    internal void SetStrategy(IStrategy strategy)
    {
      _strategy = strategy;
    }

    internal void FindBestTravelOption()
    {

    }
  }
}
