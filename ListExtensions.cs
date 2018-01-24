using System;
using System.Collections.Generic;
using System.Linq;

namespace ReeCode
{
    public static class ListExtensions
    {
        /// <summary>
        /// Checks if all values in the list are factors of a number
        /// </summary>
        /// <returns>True / False</returns>
        public static bool AreAllFactorsOf(this List<int> inputList, int x)
        {
            foreach (int num in inputList)
            {
                if (x % num != 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Checks if a List contains any letters from another List
        /// </summary>
        /// <returns>True / False</returns>
        public static bool ContainsAnyLettersFrom(this List<char> inputList, List<char> checkList)
        {
            if (inputList.Intersect(checkList).Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Finds the Median value of a list
        /// </summary>
        /// <param name="inputList"></param>
        /// <returns>The Median value</returns>
        public static double Median(this List<double> inputList)
        {
            double[] xs = inputList.ToArray();
            Array.Sort(xs);
            return xs[xs.Length / 2];
        }
    }
}