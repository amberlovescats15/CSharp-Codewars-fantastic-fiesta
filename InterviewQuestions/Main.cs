using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.InterviewQuestions
{
    public class Main
    {

        // Reverse a string
        public string Reverse(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return string.Empty;

            IEnumerable<char> reversed = s.Reverse();
            return string.Join("", reversed);
        }
        // find if given string is a palindrome
        public bool IsPalindrome(string s)
        {
            //TODO: handle lowercase
            var word = s.ToLower();
            if (string.IsNullOrWhiteSpace(word))
                return false;

            if (word.Length == 1)
                return true;

            var isPalindrome = true;
            var lengthOfArray = word.Length % 2 == 0 ? word.Length / 2: (word.Length -1) / 2;
            // hannah (3) // mom (1)
            for (int i = 0; i < lengthOfArray; i++)
            {
                var firstLetterToCompare = word[i].ToString();
                var secondLetterToCompare = word[word.Length - i - 1].ToString();
                if (firstLetterToCompare != secondLetterToCompare)
                    isPalindrome = false;
            }
            return isPalindrome;
        }
        // find substring from a given string
        public string FindSubstring(string s, string sub)
        {
            if (string.IsNullOrWhiteSpace(s) || string.IsNullOrWhiteSpace(sub))
                return string.Empty;

            var sentance = s.ToLower();
            var substringToFind = sub.ToLower();

            var index = sentance.IndexOf(substringToFind);
            if (index < 0)
                return string.Empty;

            return sentance.Substring(index, substringToFind.Length);
        }
        
        // find if the positive integer is prime or not
        public bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            var numberOfDivisors = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    numberOfDivisors++;
            }
            return numberOfDivisors == 2;
        }
        // what are singleton design patterns and how to implement them
    }
}
