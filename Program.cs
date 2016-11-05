using System;
using System.Collections.Generic;
using ReeCode;

namespace ReeCodeDemo
{
    class Demo
    {
        static void Main(string[] args)
        {
            List<double> medianList = new List<double>() { 1, 2, 3, 4, 5 };
            List<int> factorsList = new List<int>() { 2, 5, 10 };
            Console.WriteLine(medianList.Median()); // 3
            Console.WriteLine(factorsList.AreAllFactorsOf(20)); // True
            Console.ReadLine();
        }
    }
}
