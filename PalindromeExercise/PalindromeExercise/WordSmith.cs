using System;

namespace PalindromeExercise;

    public class WordSmith
    {
    public WordSmith()
    {
            
        }
        public bool IsAPalindrome(string word)
    {
        var isPalindrome = true;
        var stringLength = word.Length;
        for (int i = 0; i <= stringLength / 2; i++)
        {
            if (word[i] != word[stringLength - i - 1])
            {
                isPalindrome = false;
            }
        }
        return isPalindrome;
    }
    }
