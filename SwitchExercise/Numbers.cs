using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExercise
{
    internal class Numbers
    {
        public static int BiggestNumber(int[] numbers)
        {
            int biggestNumber = 0; //MAKES "biggestNumber" EQUAL TO 0
            foreach (int numb in numbers) //THIS LOOP CHECKS EACH NUMBER IN THE ARRAY
            {
                if (numb > biggestNumber) //THIS LINE CHECKS IF THE CURRENT NUMBER IS BIGGER THAN WHAT IS SAVED IN "biggestNumber"
                    biggestNumber = numb; //MAKES "biggestNumber" EQUAL TO THE CURRENT NUMBER
            }
            return biggestNumber; //returns the biggest number
        }

        public static int SecondBiggestNumber(int[] numbers)
        {
            int biggestNumber = 0; //MAKES "biggestNumber" EQUAL TO 0
            int secondBiggestNumber = 0; //makes "secondBiggestNumber" EQUAL TO 0
            foreach (int numb in numbers) //THIS LOOP CHECKS EACH NUMBER IN THE ARRAY
            {
                if (numb > biggestNumber) //THIS LINE CHECKS IF THE CURRENT NUMBER IS BIGGER THAN OR EQUAL TO WHAT IS SAVED IN "biggestNumber"
                    (secondBiggestNumber, biggestNumber) = (biggestNumber, numb); //MAKES "biggestNumber" EQUAL TO THE CURRENT NUMBER AND "secondBiggestNumber" EQUAL TO WHAT "biggestNumber" USED TO BE
            }
            return secondBiggestNumber; //returns the second biggest number
        }

        public static int ContainsOddNumber(int[] numbers)
        {
            int oddCounter = 0; //this initialises the counter to 0
            foreach (int numb in numbers) //this loop looks at each number in the array
            {
                if (numb%2 != 0) //this divides the number by 2 and checks if there is a remainder
                    oddCounter++; //this increments the counter when there is a remainder
            }
             return oddCounter; //this returns the amount of remainders
        }

        public static string HowManyPositiveAndNegative(int[] numbers)
        {
            int negCounter = 0; //this initialises the negative number counter to 0
            int posCounter = 0; //this initialises the positive number counter to 0
            foreach(int numb in numbers) //this loop checks each number in the array 
            {
                if (numb < 0) //this checks if the number is less than zero
                    negCounter++; //this increments the negative counter
                else if (numb > 0) //this checks if the number is more than zero
                    posCounter++; //this increments the positive counter
            }
            return $"There are {negCounter} negative numbers and {posCounter} positive numbers in the array."; //This retruns a sentence that says how many positive and negative numbers there are
        } 
    }
}
