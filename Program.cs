using System;
using System.Collections.Generic;
using ReeCode;

namespace ReeCodeDemo
{
    class Demo
    {
        static void Main(string[] args)
        {
            // ListExtensions.cs
            Console.WriteLine("ListExtensions.cs Examples");

            // AreAllFactorsOf
            List<int> factorsList = new List<int>() { 2, 5, 10 };
            Console.WriteLine("AreAllFactorsOf - Example 1: " + factorsList.AreAllFactorsOf(20)); // True

            // ContainsAnyLettersFrom
            List<char> charListA = new List<char> { 'a', 'b', 'c' };
            List<char> charListB = new List<char> { 'd', 'e', 'f' };
            List<char> charListC = new List<char> { 'g', 'h', 'b' };
            Console.WriteLine("ContainsAnyLettersFrom - Example 1: " + charListA.ContainsAnyLettersFrom(charListB)); // False
            Console.WriteLine("ContainsAnyLettersFrom - Example 2: " + charListA.ContainsAnyLettersFrom(charListC)); // True

            // Median
            List<double> medianList = new List<double>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Median - Example 1: " + medianList.Median()); // 3
            Console.WriteLine();


            // StringExtensions.cs
            Console.WriteLine("StringExtensions.cs Examples");

            // IsAPalindrome
            string notAPalindrome = "Some String";
            string isAPalindrome = "Some emoS";
            Console.WriteLine("IsAPalindrome - Example 1: " + notAPalindrome.IsAPalindrome());
            Console.WriteLine("IsAPalindrome - Example 2: " + isAPalindrome.IsAPalindrome());

            // IsAPangram
            string notAPangram = "This is not a pangram";
            string isAPangram = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine("IsAPangram - Example 1: " + notAPangram.IsAPangram()); // False
            Console.WriteLine("IsAPangram - Example 2: " + isAPangram.IsAPangram()); // True

            // Reverse
            string normalString = "This is a test";
            string reversedString = "tset a si sihT";
            Console.WriteLine("Reverse - Example 1: " + (normalString.Reverse() == reversedString)); // True

            // ToCharList
            string someString = "Hello World";
            List<char> charList = someString.ToCharList();
            Console.WriteLine("ToCharList - Example 1: " + charList.Count); // 11

            // ToBase64
            Console.WriteLine("Base64Encode: " + "Hello World!!".ToBase64());

            // FromBase64
            Console.WriteLine("Base64Decode: " + "SGVsbG8gV29ybGQhIQ==".FromBase64()); // Hello World!!

            // ToROT13
            Console.WriteLine("ROT13: " + "Uryyb Jbeyq!".ToROT13()); // Hello World!
            Console.ReadLine();
        }
    }
}
