public static class Languages
{
    public static List<string> NewList() => new List<string>();

    public static List<string> GetExistingLanguages()
    {
        var existingLanguages = new List<string>() {"C#", "Clojure", "Elm"};
        return existingLanguages;
    }

    public static List<string> AddLanguage(List<string> languages, string language) => languages.Append(language).ToList();

    public static int CountLanguages(List<string> languages) => languages.Count;

    public static bool HasLanguage(List<string> languages, string language) => languages.Contains(language);

    public static List<string> ReverseList(List<string> languages) => languages.Reverse<string>().ToList();
        
    public static bool IsExciting(List<string> languages) {
        if (languages.Count == 0) {
            return false;
        } else if (languages[0] == "C#") {
            return true;
        } else if (languages[1] == "C#" && languages.Count <= 3) {
            return true;
        } else {
            return false;
        }
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages) => languages.Count == languages.Distinct().Count();
}
