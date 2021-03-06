namespace Strategy.TravelOptions
{
  internal class CarTravel : ITravelOption
  {
    public int Cost => 5;
    public int Time => 2;
  }
}
