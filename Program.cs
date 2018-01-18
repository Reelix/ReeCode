using System;
using System.Collections.Generic;
using ReeCode;
using System.Net;

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
            Console.WriteLine("AreAllFactorsOf - Example: " + factorsList.AreAllFactorsOf(20)); // True

            // ContainsAnyLettersFrom
            List<char> charListA = new List<char> { 'a', 'b', 'c' };
            List<char> charListB = new List<char> { 'd', 'e', 'f' };
            List<char> charListC = new List<char> { 'g', 'h', 'b' };
            Console.WriteLine("ContainsAnyLettersFrom - Example 1: " + charListA.ContainsAnyLettersFrom(charListB)); // False
            Console.WriteLine("ContainsAnyLettersFrom - Example 2: " + charListA.ContainsAnyLettersFrom(charListC)); // True

            // Median
            List<double> medianList = new List<double>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Median - Example: " + medianList.Median()); // 3
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
            Console.WriteLine("Reverse - Example: " + (normalString.Reverse() == reversedString)); // True

            // ToCharList
            string someString = "Hello World";
            List<char> charList = someString.ToCharList();
            Console.WriteLine("ToCharList - Example: " + charList.Count); // 11

            // RemoveUntil
            string longString = "This is some data we don't need and a search point. Important Text Here";
            Console.WriteLine("RemoveUntil - Example 1: " + longString.RemoveUntil("point. ", false)); // "point. Important Text Here"
            Console.WriteLine("RemoveUntil - Example 2: " + longString.RemoveUntil("point. ", true)); // "Important Text Here"

            // Mostly Cryptography stuff
            // ToBase64
            Console.WriteLine("Base64Encode - Example: " + "Hello World!!".ToBase64()); // SGVsbG8gV29ybGQhIQ==

            // FromBase64
            Console.WriteLine("Base64Decode - Example: " + "SGVsbG8gV29ybGQhIQ==".FromBase64()); // Hello World!!

            // ToROT13
            Console.WriteLine("ROT13 - Example: " + "Uryyb Jbeyq!".ToROT13()); // Hello World!

            // ToSHA1
            Console.WriteLine("SHA1 - Example: " + "Hello World!".ToSHA1()); // 2ef...

            // ToSHA512 (The result is 128 characters long)
            Console.WriteLine("SHA512 - Example: " + "Hello World!".ToSHA512()); // 861...
            Console.WriteLine();

            Console.WriteLine("Press Enter to load the WebClient examples");
            Console.ReadLine();

            // WebClient.cs
            Console.WriteLine("Loading WebClient.cs examples...");
            WebClient wc = new WebClient();
            wc.SetForwarded("google.com");
            wc.SetVia("bob.com"); // Does not show in rest example
            string result = wc.Post("https://httpbin.org/anything", new List<string> { "postNameHere=postValueHere", "postNameHere2=postValueHere2" });
            Console.WriteLine("Post Test: \n" + result);
            Console.ReadLine();
        }
    }
}