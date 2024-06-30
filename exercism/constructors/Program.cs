using System;

class RemoteControlCar
{
  // TODO: define the constructor for the 'RemoteControlCar' class
  private int _speed;
  private int _batteryDrain;
  private int _distance;
  private int _battery = 100;

  public RemoteControlCar(int speed, int batteryDrain)
  {
    this._speed = speed;
    this._batteryDrain = batteryDrain;
  }

  public bool BatteryDrained() => _battery == 0 || _battery < _batteryDrain;

  public int DistanceDriven() => _distance;

  public void Drive()
  {
    if (_battery > 0 && _battery >= _batteryDrain)
    {
      _distance += _speed;
      _battery -= _batteryDrain;
    }

  }

  public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
  // TODO: define the constructor for the 'RaceTrack' class
  private int _distance;

  public RaceTrack(int distance)
  {
    this._distance = distance;
  }

  public bool TryFinishTrack(RemoteControlCar car)
  {
    while (car.DistanceDriven() < _distance && car.BatteryDrained() == false)
    {
      car.Drive();

      if (car.DistanceDriven() >= _distance)
      {
        return true;
      }
    }

    return false;
  }
}
