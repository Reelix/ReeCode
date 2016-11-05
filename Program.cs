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
            // Median
            List<double> medianList = new List<double>() { 1, 2, 3, 4, 5 };
            Console.WriteLine(medianList.Median()); // 3

            // AreAllFactorsOf
            List<int> factorsList = new List<int>() { 2, 5, 10 };
            Console.WriteLine(factorsList.AreAllFactorsOf(20)); // True

            // StringExtensions.cs
            // IsAPangram
            string notAPangram = "This is not a pangram";
            string isAPangram = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine(notAPangram.IsAPangram()); // False
            Console.WriteLine(isAPangram.IsAPangram()); // True
            Console.ReadLine();
        }
    }
}
