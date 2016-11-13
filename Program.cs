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
            // Median
            List<double> medianList = new List<double>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Median - Example 1: " + medianList.Median()); // 3

            // AreAllFactorsOf
            List<int> factorsList = new List<int>() { 2, 5, 10 };
            Console.WriteLine("AreAllFactorsOf - Example 1: " + factorsList.AreAllFactorsOf(20)); // True

            // ContainsAnyLettersFrom
            List<char> charListA = new List<char> { 'a', 'b', 'c' };
            List<char> charListB = new List<char> { 'd', 'e', 'f' };
            List<char> charListC = new List<char> { 'g', 'h', 'b' };
            Console.WriteLine("ContainsAnyLettersFrom - Example 1: " + charListA.ContainsAnyLettersFrom(charListB)); // False
            Console.WriteLine("ContainsAnyLettersFrom - Example 2: " + charListA.ContainsAnyLettersFrom(charListC)); // True
            Console.WriteLine();

            // StringExtensions.cs
            Console.WriteLine("StringExtensions.cs Examples");
            // IsAPangram
            string notAPangram = "This is not a pangram";
            string isAPangram = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine("IsAPangram - Example 1: " + notAPangram.IsAPangram()); // False
            Console.WriteLine("IsAPangram - Example 2: " + isAPangram.IsAPangram()); // True

            // ToCharList
            string someString = "Hello World";
            List<char> charList = someString.ToCharList();
            Console.WriteLine("ToCharList - Example 1: " + charList.Count); // 11
            Console.ReadLine();
        }
    }
}
