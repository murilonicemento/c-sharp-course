using System;

class RemoteControlCar
{
  private int _distance;
  private int _battery = 100;

  public static RemoteControlCar Buy()
  {
    return new RemoteControlCar();
    throw new NotImplementedException("Please implement the (static) RemoteControlCar.Buy() method");
  }

  public string DistanceDisplay()
  {
    return $"Driven {_distance} meters";
    throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDisplay() method");
  }

  public string BatteryDisplay()
  {
    if (_battery == 0)
    {
      return "Battery empty";
    }
    return $"Battery at {_battery}%";
    throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDisplay() method");
  }

  public void Drive()
  {
    if (_battery > 0)
    {
      _distance += 20;
      _battery -= 1;
    }
  }
}
