static class LogLine
{
    public static string Message(string logLine)
    {
        int index = logLine.IndexOf(":");
        return logLine.Substring(index+1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int beginIndex = logLine.IndexOf("[");
        int endIndex = logLine.IndexOf("]");
        string word = logLine.Substring(beginIndex+1, endIndex-beginIndex-1);
        return word.ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
