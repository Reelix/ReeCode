using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

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

        /// <summary>
        /// Converts a string to Base64
        /// </summary>
        /// <param name="inputString"></param>
        public static string ToBase64(this string inputString)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(inputString);
            return Convert.ToBase64String(plainTextBytes);
        }

        /// <summary>
        /// Converts a Base64 encoded string to plain text
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string FromBase64(this string inputString)
        {
            var base64EncodedBytes = Convert.FromBase64String(inputString);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
        /// <summary>
        /// Encodes a string with the ROT13 Cipher
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        // Taken from https://www.dotnetperls.com/rot13
        public static string ToROT13(this string input)
        {
            char[] array = input.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }
            return new string(array);
        }

        public static string ToSHA1(this string input)
        {
            var hash = (new SHA1Managed()).ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Join("", hash.Select(b => b.ToString("x2")).ToArray());
        }
    }
}