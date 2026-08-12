static class LogLine
{
    public static string Message(string logLine)
    {
        int index = logline.IndexOf(":");
        return logline.substring(index+1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int beginIndex = logline.IndexOf("[");
        int endIndex = logline.IndexOf("]");
        string word = logline.substring(beginIndex+1,endIndex-beginIndex-1);
        return word.ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logline)} ({LogLevel(logline)})";
    }
}
