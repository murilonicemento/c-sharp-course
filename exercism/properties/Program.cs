using System;

class WeighingMachine
{
  // TODO Define the 'Precision' property
  private int precision;
  public int Precision { get { return this.precision; } set { Precision = this.precision; } }

  // TODO Define the 'Weight' property
  private double weight;
  public double Weight
  {
    get { return this.weight; }
    set
    {
      if (value < 0)
      {
        throw new ArgumentOutOfRangeException();
      }

      this.weight = value;
    }
  }

  // TODO Define the 'DisplayWeight' property
  public string DisplayWeight
  {
    get
    {
      double displayWeight = Math.Round(Weight - TareAdjustment, Precision);
      return $"{displayWeight.ToString("f" + Precision)} kg";
    }
  }

  // TODO Define the 'TareAdjustment' property
  public double TareAdjustment { get; set; } = 5;

  public WeighingMachine(int precision)
  {
    this.precision = precision;
  }
}