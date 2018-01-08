# ReeCode
Just some useful C# type extensions. Mainly used for programming challenges.

List Extension Methods
----------------------
- AreAllFactorsOf(int x) - A List\<int\> extension method that tests if all the numbers in the list are factors of x
- ContainsAnyLettersFrom(List\<char\> charList) - A List\<char\> extension method that tests if one list of letters contains any letters from another list of letters
- Median() - A List\<double\> extension method that finds the [median](https://en.wikipedia.org/wiki/Median) value of a list of numbers
  
String Extension Methods
------------------------
- IsAPalindrome() - A String extension method that tells if a specific string is a [palindrome](https://en.wikipedia.org/wiki/Palindrome)
- IsAPangram() - A String extension method that tells if a specific string is a [pangram](https://en.wikipedia.org/wiki/Pangram)
- Reverse() - A String extension method that reverses a string
- ToCharList() - A String extension method that converts a string to a List\<char\>
- ToBase64() - Encodes  a string with [Base64](https://en.wikipedia.org/wiki/Base64)
- FromBase64() - Decodes a Base64 encoded string
- ToROT13() - Encodes a string with the [ROT13](https://en.wikipedia.org/wiki/ROT13) substitution cipher
