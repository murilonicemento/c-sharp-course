﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Identifier
{
  public static string Clean(string s)
  {
    var result = "";
    var upperNext = false;
    foreach (var c in s)
    {
      if (c == ' ')
        result += "_";
      else if (c < 13)
        result += "CTRL";
      else if (c >= 'α' && c <= 'ω')
        continue;
      else if (c == '-')
        upperNext = true;
      else if (upperNext)
      {
        result += char.ToUpper(c);
        upperNext = false;
      }
      else if (char.IsLetter(c))
        result += c;
    }
    return result;
  }
}
