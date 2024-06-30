using System;

public static class PhoneNumber
{
  public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
  {
    string first = phoneNumber.Substring(0, 3);
    string second = phoneNumber.Substring(4, 3);
    string last = phoneNumber.Substring(8);
    bool ny = false;
    bool fake = false;

    if (first == "212")
    {
      ny = true;
    }
    if (second == "555")
    {
      fake = true;
    }

    return (ny, fake, last);
    throw new NotImplementedException($"Please implement the (static) PhoneNumber.Analyze() method");
  }

  public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
  {
    return phoneNumberInfo.IsFake;
    throw new NotImplementedException($"Please implement the (static) PhoneNumber.IsFake() method");
  }
}
