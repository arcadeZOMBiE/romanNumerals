using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralConverter
    {
        private readonly Dictionary<int, string> keyValues = new()
        {
            {1000,"M"},
            {900,"CM"},
            {500,"D"},
            {400,"CD"},
            {100,"C"},
            {90,"XC"},
            {50,"L"},
            {40,"XL"},
            {10,"X"},
            {9,"IX"},
            {5,"V"},
            {4,"IV"},
            {1,"I"}
        };

        public string ConvertToRomanNumerals(int value)
        {
            StringBuilder returnValue = new();

            foreach (var key in keyValues)
            {
                var count = value / key.Key;
                for(int i = 0; i < count; i++)
                {
                    returnValue.Append(key.Value);
                }
                value %= key.Key;
            }

            return returnValue.ToString();
        }

        public int ConvertToInteger(string RomanNumerals)
        {
            var returnValue = 0;
          
            for(var i = 2; i > 0; i--)
            {
                foreach (var key in keyValues)
                {
                    if (key.Value.Length == i)
                    {
                        int pos = 0;
                        while ((pos = RomanNumerals.IndexOf(key.Value)) != -1)
                        {
                            returnValue += key.Key;
                            RomanNumerals = RomanNumerals.Remove(pos, i);
                        }
                    }
                }
            }

            return returnValue;
        }
    }
}
