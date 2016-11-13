using System.Collections.Generic;
using System.Linq;

namespace ReeCode
{
    public static class StringExtensions
    {
        /// <summary>
        /// Checks if a string is a Pangram
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns a list of each character in the string
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static List<char> ToCharList(this string inputString)
        {
            List<char> charList = inputString.Select(x => x).ToList();
            return charList;
        }
    }
}
