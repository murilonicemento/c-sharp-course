using System;

static class SavingsAccount
{
  public static float InterestRate(decimal balance)
  {
    if (balance < 0)
    {
      return 3.213f;
    }
    else if (balance < 1000)
    {
      return 0.5f;
    }
    else if (balance >= 1000 && balance < 5000)
    {
      return 1.621f;
    }
    else if (balance >= 5000)
    {
      return 2.475f;
    }
    throw new NotImplementedException("Please implement the (static) SavingsAccount.InterestRate() method");
  }

  public static decimal Interest(decimal balance)
  {
    return balance * (decimal)(SavingsAccount.InterestRate(balance) / 100);
    throw new NotImplementedException("Please implement the (static) SavingsAccount.Interest() method");
  }

  public static decimal AnnualBalanceUpdate(decimal balance)
  {
    return balance + SavingsAccount.Interest(balance);
    throw new NotImplementedException("Please implement the (static) SavingsAccount.AnnualBalanceUpdate() method");
  }

  public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
  {
    int years = 0;
    while (balance < targetBalance)
    {
      balance = AnnualBalanceUpdate(balance);
      years++;
    }
    return years;
    throw new NotImplementedException("Please implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method");
  }
}
