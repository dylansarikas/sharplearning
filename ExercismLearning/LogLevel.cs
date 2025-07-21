static class LogLine
{
    public static string Message(string logLine) => logLine.Substring(logLine.LastIndexOf(":") + 1).Trim();

    public static string LogLevel(string logLine) => logLine.Substring(1, logLine.LastIndexOf("]") - 1).ToLower();

    public static string Reformat(string logLine) => $"{LogLine.Message(logLine)} ({LogLine.LogLevel(logLine)})";
}
