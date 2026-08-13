public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string firstPart = phoneNumber.Substring(0, 3);
        string secondPart = phoneNumber.Substring(4, 3);
        string localNumber = phoneNumber.Substring(8, 4);

        bool isNewYork = firstPart == "212" ? true : false;
        bool isFake = secondPart == "555" ? true : false;

        return (isNewYork, isFake, localNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
