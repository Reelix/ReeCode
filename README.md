# ReeCode
Just some useful C# type extensions. Mainly used for programming challenges.

List Extension Methods
----------------------
- AreAllFactorsOf(int x) - A List\<int\> extension method that tests if all the numbers in the list are factors of x - Returns a boolean
- ContainsAnyLettersFrom(List\<char\> charList) - A List\<char\> extension method that tests if one list of letters contains any letters from another list of letters - Returns a boolean
- Median() - A List\<double\> extension method that finds the [median](https://en.wikipedia.org/wiki/Median) value of a list of numbers - Returns a double
  
String Extension Methods
------------------------
- IsAPalindrome() - Tells if a specific string is a [palindrome](https://en.wikipedia.org/wiki/Palindrome) - Returns a boolean
- IsAPangram() - Tells if a specific string is a [pangram](https://en.wikipedia.org/wiki/Pangram) - Returns a boolean
- Reverse() - Reverses a string
- ToCharList() - Converts a string to a List\<char\>
- RemoveUntil(string searchString, bool tillEnd) - Removes all the characters from the start of a string up until the start (Or end) of the term term
- ToBase64() - Encodes  a string with [Base64](https://en.wikipedia.org/wiki/Base64)
- FromBase64() - Decodes a Base64 encoded string
- ToROT13() - Encodes a string with the [ROT13](https://en.wikipedia.org/wiki/ROT13) substitution cipher
- ToSHA1() - Encodes a string with the [SHA-1](https://en.wikipedia.org/wiki/SHA-1) hash function
- ToSHA512() - Encodes a string with the [SHA-512](https://en.wikipedia.org/wiki/SHA-512) hash function

WebClient Extension Methods
---------------------------
- SetForwarded(string x) - Sets the Forwarded header to x
- SetVia(string x) - Sets the Via header to x
- Post(string URL, List<string> postValues) - An easy method to do POST requests - Returns a string
