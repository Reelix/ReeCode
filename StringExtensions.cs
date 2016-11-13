using System;
using System.Collections.Generic;
using System.Linq;

namespace ReeCode
{
    public static class StringExtensions
    {

        /// <summary>
        /// Checks if a string is a Palindrome
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>True / False</returns>
        public static bool IsAPalindrome(this string inputString)
        {
            if (inputString == inputString.Reverse())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if a string is a Pangram
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>True / False</returns>
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
        /// Reverses a string
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>The reversed string</returns>
        public static string Reverse(this string inputString)
        {
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            return reversedString;
        }

        /// <summary>
        /// Converts a string to a list of characters
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>A list containing each character in the string</returns>
        public static List<char> ToCharList(this string inputString)
        {
            List<char> charList = inputString.Select(x => x).ToList();
            return charList;
        }
    }
}
