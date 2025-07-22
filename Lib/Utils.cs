namespace Utils
{
    public static class Utils
    {
        public static bool IsLeapYear(int year)
        {
            if (year % 4 != 0)
            {
                return false;
            }

            if (year % 100 == 0 && year % 400 != 0)
            {
                return false;
            }

            return true;
        }

        public static string Sum(string num1Str, string num2Str)
        {
            if (TryParseNatualNumberStr(num1Str, out int num1) && TryParseNatualNumberStr(num2Str, out int num2))
            {
                return (num1 + num2).ToString();
            }

            return "0";
        }

        private static bool TryParseNatualNumberStr(string input, out int naturalNumber)
        {
            return int.TryParse(input, out naturalNumber) && naturalNumber >= 0;
        }
    }
}
