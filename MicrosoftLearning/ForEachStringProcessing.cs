string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];
int periodLocation;

foreach (string miniString in myStrings)
{
    string processString = miniString;
    while (processString.Contains('.'))
    {
        periodLocation = processString.IndexOf('.');
        Console.WriteLine($"{processString.Remove(periodLocation)}");
        processString = processString.Substring(periodLocation + 1).TrimStart();
    }
    Console.WriteLine($"{processString}");
}