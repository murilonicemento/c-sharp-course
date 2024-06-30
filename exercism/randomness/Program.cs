using System;

public class Player
{
  public int RollDie()
  {
    Random random = new Random();
    return random.Next(1, 18);
    throw new NotImplementedException("Please implement the Player.RollDie() method");
  }

  public double GenerateSpellStrength()
  {
    Random random = new Random();
    return random.NextDouble();
    throw new NotImplementedException("Please implement the Player.GenerateSpellStrength() method");
  }
}
