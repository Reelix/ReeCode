using System.Collections.Generic;
using System.Linq;

namespace ReeCode
{
    public static class StringExtensions
    {
        public static bool IsAPangram(this string inputString)
        {
            inputString = inputString.ToLower();
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (!inputString.Contains(c.ToString()))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
