using System;

static class AssemblyLine
{
  public static double SuccessRate(int speed)
  {
    if (speed == 0)
    {
      return 0.00;
    }
    else if (speed > 0 && speed < 5)
    {
      return 1.00;
    }
    else if (speed > 4 && speed < 9)
    {
      return 0.90;
    }
    else if (speed == 9)
    {
      return 0.80;
    }
    else
    {
      return 0.77;
    }
    throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
  }

  public static double ProductionRatePerHour(int speed)
  {
    double successRate = AssemblyLine.SuccessRate(speed);
    double result = (speed * 221) * successRate;

    return result;

    throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
  }

  public static int WorkingItemsPerMinute(int speed)
  {
    double hourRate = AssemblyLine.ProductionRatePerHour(speed);
    int result = Convert.ToInt32(Math.Floor(hourRate / 60));

    return result;
    throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
  }
}
