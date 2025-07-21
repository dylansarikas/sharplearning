public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string after) => str.Substring(str.IndexOf(after) + after.Length);   

    public static string SubstringBetween(this string str, string first, string second) => str.Substring((str.IndexOf(first) + first.Length), str.IndexOf(second) - (str.IndexOf(first) + first.Length));
    
    public static string Message(this string str) => str.SubstringAfter(": ");

    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}