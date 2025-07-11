public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool IsNewYork = phoneNumber.Substring(0, 3) == "212" ? true : false;
        bool IsFake = phoneNumber.Substring(4, 3) == "555" ? true : false;
        string LocalNumber = phoneNumber.Substring(8, 4);
        return (IsNewYork, IsFake, LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
}
