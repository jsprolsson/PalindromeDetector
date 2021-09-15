using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Palindrom_detektor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write output: ");
            string wordInput = Console.ReadLine();                  
            string reversedWord = Reverse(wordInput);                  
                                                                       
           string trimmedWordInput = RemoveChar(wordInput);
           string trimmedReversedWord = RemoveChar(reversedWord);

            CheckIfPalindrome(trimmedWordInput.ToLower(), trimmedReversedWord.ToLower());                 

        }


        public static string Reverse(string s)              
        {
            char[] charArray = s.ToCharArray();             
            Array.Reverse(charArray);                       
            return new string(charArray);                   
        }


        public static string RemoveChar(string wordInput)
        {
            string wordTrimmed = Regex.Replace(wordInput, @" ", "");

            return wordTrimmed;
        }

        public static void CheckIfPalindrome(string wordInput, string reversedWord)
        {

            if (wordInput == reversedWord)
            {

                Console.WriteLine("The word is a palindrome.");
            }
            else if(wordInput != reversedWord)
            {
                Console.WriteLine("The word is NOT a palindrome.");
            }
            
        }
    }
}
