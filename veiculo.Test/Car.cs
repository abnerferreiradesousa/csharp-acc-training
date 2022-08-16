namespace veiculo.Test;
public class Car {
  double _topSpeedKph;
  public double TopSpeed 
  {
    get { return _topSpeedKph; }
    set { _topSpeedKph = value; }
  } 

  public static double KphToMph(double speedKph) 
  {
    return speedKph / 1.61;
  }

  public double TopSpeedMph 
  {
    get { return Car.KphToMph(_topSpeedKph); }
  }
}