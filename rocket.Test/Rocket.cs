namespace rocket.Test;

class Rocket
{
  string Name { get; set; }
  int Fuel { get; set; } = 0;
  decimal Price { get; set; }

  public Rocket(string name, decimal price)
  {
    this.Name = name;
    Price = price;
  }
}