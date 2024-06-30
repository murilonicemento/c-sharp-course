using System;

static class Badge
{
  public static string Print(int? id, string name, string? department)
  {
    string identifier = $"[{id}] - ";
    if (id == null)
    {
      identifier = "";
    }
    string owner = department ?? "OWNER";

    return $"{identifier}{name} - {owner.ToUpper()}";
    throw new NotImplementedException("Please implement the (static) Badge.Print() method");
  }
}
