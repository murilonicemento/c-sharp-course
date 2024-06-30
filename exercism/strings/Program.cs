using System;

static class LogLine
{
  public static string Message(string logLine)
  {
    int first = logLine.IndexOf(":") + 1;
    string result = logLine.Substring(first);

    return result.Trim();
    throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
  }

  public static string LogLevel(string logLine)
  {
    int first = logLine.IndexOf("[") + 1;
    int last = logLine.IndexOf("]") - 1;
    string result = logLine.Substring(first, last);

    return result.ToLower();
    throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
  }

  public static string Reformat(string logLine)
  {
    string nevel = $"({LogLine.LogLevel(logLine)})";
    string message = LogLine.Message(logLine);

    return $"{message} {nevel}";
    throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
  }
}
