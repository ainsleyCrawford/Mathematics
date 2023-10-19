namespace Mathematics
{
    internal class Ordinal_Indicator
    {
        internal static string GetSuffix(int n) => (n % 10 == 1 && n != 11) ? "st" : (n % 10 == 2 && n != 12) ? "nd" : (n % 10 == 3 && n != 13) ? "rd" : "th";
    }
}
