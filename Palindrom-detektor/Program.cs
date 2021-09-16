using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Palindrom_detektor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Palindrome Detector!");
            Console.WriteLine("--------------------------------------");

            int userInput;
            do
            {
                Console.WriteLine("Do you want to: \n1. Run Detector Program\n2. Exit");
                userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        PalindromeDetector.RunDetector();
                        break;
                    case 2:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();

            } while (userInput != 2);


        }

        class PalindromeDetector
        {

            public static void RunDetector()
            {
                Console.Write("Write possible palindrome word: ");
                string wordInput = Console.ReadLine();
                string reversedWord = Reverse(wordInput);

                string trimmedWordInput = RemoveChar(wordInput);
                string trimmedReversedWord = RemoveChar(reversedWord);

                CheckIfPalindrome(trimmedWordInput.ToLower(), trimmedReversedWord.ToLower());
            }


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
