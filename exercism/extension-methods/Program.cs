using System;

public static class LogAnalysis
{
  // Define o método de extensão 'SubstringAfter' no tipo 'string'
  public static string SubstringAfter(this string content, string param)
  {
    if (content == null || param == null)
    {
      return null;
    }

    int first = content.IndexOf(param);
    if (first == -1)
    {
      return null;
    }

    return content.Substring(first + param.Length);
  }

  // Define o método de extensão 'SubstringBetween' no tipo 'string'
  public static string SubstringBetween(this string content, string param1, string param2)
  {
    if (content == null || param1 == null || param2 == null)
    {
      return null;
    }

    int start = content.IndexOf(param1);
    if (start == -1)
    {
      return null;
    }

    start += param1.Length;
    int end = content.IndexOf(param2, start);
    if (end == -1)
    {
      return null;
    }

    return content.Substring(start, end - start);
  }

  // Define o método de extensão 'Message' no tipo 'string'
  public static string Message(this string content)
  {
    return content.SubstringBetween(": ", ".") + ".";
  }

  // Define o método de extensão 'LogLevel' no tipo 'string'
  public static string LogLevel(this string content)
  {
    return content.SubstringBetween("[", "]");
  }
}