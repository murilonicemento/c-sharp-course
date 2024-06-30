using System;

class BirdCount
{
  private int[] birdsPerDay;

  public BirdCount(int[] birdsPerDay)
  {
    this.birdsPerDay = birdsPerDay;
  }

  public static int[] LastWeek() => new int[] { 0, 2, 5, 3, 7, 8, 4 };

  public int Today() => this.birdsPerDay[this.birdsPerDay.Length - 1];

  public void IncrementTodaysCount()
  {
    this.birdsPerDay[this.birdsPerDay.Length - 1] = this.Today() + 1;
  }

  public bool HasDayWithoutBirds()
  {
    for (int i = 0; i < this.birdsPerDay.Length; i++)
    {
      if (this.birdsPerDay[i] == 0)
      {
        return true;
      }
    }

    return false;
  }

  public int CountForFirstDays(int numberOfDays)
  {
    int sum = 0;

    for (int i = 0; i < numberOfDays; i++)
    {
      sum += this.birdsPerDay[i];
    }

    return sum;
  }

  public int BusyDays()
  {
    int busyDays = 0;

    foreach (int day in birdsPerDay)
    {
      if (day >= 5)
      {
        busyDays++;
      }
    }

    return busyDays;
  }
}
