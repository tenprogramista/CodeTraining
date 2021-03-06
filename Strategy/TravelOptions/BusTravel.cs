namespace Strategy.TravelOptions
{
  internal class BusTravel : ITravelOption
  {
    public int Cost => 2;
    public int Time => 3;
  }
}
