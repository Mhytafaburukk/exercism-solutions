using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string value, string delimiter)
    {
        int index = value.IndexOf(delimiter);
        if (index == -1)
        {
            return string.Empty;
        }
        return value.Substring(index + delimiter.Length);
    }

    public static string SubstringBetween(this string value, string firstDelimiter, string secondDelimiter)
    {
        int startIndex = value.IndexOf(firstDelimiter) + firstDelimiter.Length;
        int endIndex = value.IndexOf(secondDelimiter);
        
        return value.Substring(startIndex, endIndex - startIndex);
    }

    public static string Message(this string value)
    {
        return value.SubstringAfter(": ");
    }

    public static string LogLevel(this string value)
    {
        return value.SubstringBetween("[", "]");
    }
}