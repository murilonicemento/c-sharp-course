using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World");

      string aFriend = "Bill";
      Console.WriteLine(aFriend);

      aFriend = "Maria";
      Console.WriteLine(aFriend);

      Console.WriteLine("Hello " + aFriend);

      // Interpolação de caracteres
      Console.WriteLine($"Hello {aFriend}");

      string firstFriend = "Maria";
      string secondFriend = "Sage";
      Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

      Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
      Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

      // Remove espaços
      string greeting = "      Hello World!       ";
      Console.WriteLine($"[{greeting}]");

      string trimmedGreeting = greeting.TrimStart();
      Console.WriteLine($"[{trimmedGreeting}]");

      trimmedGreeting = greeting.TrimEnd();
      Console.WriteLine($"[{trimmedGreeting}]");

      trimmedGreeting = greeting.Trim();
      Console.WriteLine($"[{trimmedGreeting}]");

      // Substituição de strings
      string sayHello = "Hello World!";
      Console.WriteLine(sayHello);
      sayHello = sayHello.Replace("Hello", "Greetings");
      Console.WriteLine(sayHello);

      Console.WriteLine(sayHello.ToUpper());
      Console.WriteLine(sayHello.ToLower());

      // Localizar strings
      string songLyrics = "You say goodbye, and I say hello";
      Console.WriteLine(songLyrics.Contains("goodbye"));
      Console.WriteLine(songLyrics.Contains("greetings"));

      Console.WriteLine(songLyrics.StartsWith("You"));
      Console.WriteLine(songLyrics.StartsWith("goodbye"));

      Console.WriteLine(songLyrics.EndsWith("hello"));
      Console.WriteLine(songLyrics.EndsWith("goodbye"));

      // Matemática dos inteiros
      int a = 18;
      int b = 6;
      int c = a + b;
      Console.WriteLine(c);
      c = a - b;
      Console.WriteLine(c);
      c = a * b;
      Console.WriteLine(c);
      c = a / b;
      Console.WriteLine(c);

      // Ordem das operações
      a = 5;
      b = 4;
      c = 2;
      int d = a + b * c;
      Console.WriteLine(d);
      d = (a + b) * c;
      Console.WriteLine(d);
      d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
      Console.WriteLine(d);
      d = (a + b) / c;
      Console.WriteLine(d);

      // Precisão de inteiros e limites
      a = 7;
      b = 4;
      c = 3;
      d = (a + b) / c;
      int e = (a + b) % c;
      Console.WriteLine($"quotient: {d}");
      Console.WriteLine($"remainder: {e}");

      int max = int.MaxValue;
      int min = int.MinValue;
      Console.WriteLine($"The range of integers is {min} to {max}");

      int what = max + 3;
      Console.WriteLine($"An example of overflow: {what}");

      // Tipo double
      double ad = 5;
      double bd = 4;
      double cd = 2;
      double dd = (ad + bd) / cd;
      Console.WriteLine(dd);

      ad = 19;
      bd = 23;
      cd = 8;
      dd = (ad + bd) / cd;
      Console.WriteLine(dd);

      double maxd = double.MaxValue;
      double mind = double.MinValue;
      Console.WriteLine($"The range of double is {mind} to {maxd}");
    }
  }
}