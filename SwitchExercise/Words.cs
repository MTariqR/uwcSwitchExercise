using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExercise
{
    internal class Words
    {
        public static string ReverseString(string forwardText)
        {
            string reverseText = ""; //This creates an empty string
            for (int i = forwardText.Length - 1; i >= 0; i--) //This loop checks each character in the input string starting from the back and going forward
            {
                reverseText += forwardText[i]; //This apends the character to the empty string as it is checked
            }
            return reverseText; //retruns the string
        }
        public static string CamelCase(string inString)
        {
            string[] inStringArray = inString.Split(' '); //This creates an array of words from the input string
            string camelString = ""; //This creates an empty string

            foreach (string word in inStringArray) //This loop checks each word in the array
            {
                camelString += char.ToUpper(word[0]); //This appends the first letter of the word in upper case to the string
                for (int i = 1; i < word.Length;i++) //This loop checks the rest of the letters in the word 
                {
                    camelString = camelString + char.ToLower(word[i]); //This appends the letters in lower case to the string
                }
                camelString += " "; //This appends a space to the string
            }

            return camelString; //This returns the string
        }

        public static string RemoveVowels(string inString)
        {
            string vowels = "aeiouAEIOU"; //This is a string of vowels in lowercase and uppercase
            string stringNoVowels = new string (inString.Where(c => !vowels.Contains(c)).ToArray()); //This creates a new string by checking the input and appending each character that doesn't match with the letters in vowels
            return stringNoVowels; //This returns the enw string
        }

        public static string LongestWord(string inString)
        {
            string[] inStringArray = inString.Split(' '); //This converts the input into an array of words
            string longestWord = ""; //This creates an empty string
            foreach (string word in inStringArray) //this loop checks each word in the array
                if (word.Length > longestWord.Length) //this compares the length of the word in the array to the length of longestWord
                    longestWord = word; //if the word in the array is longer than the variable "longestWord" then this line changes the variable "longestWord" into the word from the array
            return longestWord; //this returns the longest word
        }

        public static string RemoveVowel(string inString)
        {
            string[] inStringArray = inString.Split(" ");
            string noVowels = "";
            foreach (string word in inStringArray)
            {
                foreach (char letter in word)
                    if ((char.ToUpper(letter) != 'A')&(letter != 'E')&(char.ToUpper(letter) != 'I')&(char.ToUpper(letter) != 'O')&(char.ToUpper(letter) != 'U'))
                        noVowels += letter;
                noVowels += " ";
            }
            return noVowels;
        }
    }
}
