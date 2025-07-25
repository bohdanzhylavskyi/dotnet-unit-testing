namespace Utils
{
    public class StringSumUtility
    {
        public static string Sum(string num1Str, string num2Str)
        {
            int num1 = TryParseNaturalNumberStr(num1Str) ?? 0;
            int num2 = TryParseNaturalNumberStr(num2Str) ?? 0;

            return (num1 + num2).ToString();
        }

        private static int? TryParseNaturalNumberStr(string input)
        {
            if (int.TryParse(input, out int intNumber) && intNumber >= 0)
            {
                return intNumber;
            }

            return null;
        }
    }
}
