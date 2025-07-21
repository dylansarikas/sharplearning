using System;
using System.Text;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        identifier = Regex.Replace(identifier, @"\s", "_");
        identifier = Regex.Replace(identifier, "\0", "CTRL");
        identifier = Regex.Replace(identifier, "-.", m => m.Value[1].ToString().ToUpper());
        identifier = Regex.Replace(identifier, @"[^\p{L}\s_]+", "");
        identifier = Regex.Replace(identifier, "[\u03B1-\u03C9]", "");
        return identifier;
    }
}
