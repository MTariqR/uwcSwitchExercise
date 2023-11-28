using System.Threading.Channels;

namespace SwitchExercise
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            var switchOnOff = true;

            while (switchOnOff)
            {
                Console.WriteLine("Please enter a number to choose what exercise to run\n1: Reverse Text\n" +
                    "2: CamelCase\n3: Biggest Number\n4: Second Biggest Number\n5: Contains an Odd Number?\n" +
                    "6: Remove vowels from string\n7: How many even and odd numbers\n8: Get the average of " +
                    "five numbers\n9: Find the longest word in a sentence\n0: Exit");
                string switchString = Console.ReadLine();




                switch (switchString)
                {
                    case "1":
                        {
                            string case1String;
                            Console.WriteLine("Enter text and the program will reverse it");
                            case1String = Console.ReadLine();
                            Console.WriteLine(Words.ReverseString(case1String) + "\n");
                            break;
                        }
                    case "2":
                        {
                            string case2String;
                            Console.WriteLine("Enter text and the program will make the first letter of" +
                                " each word upper case and the rest of the letters in each word lower case");
                            case2String = Console.ReadLine();
                            Console.WriteLine(Words.CamelCase(case2String));
                            break;
                        }
                    case "3":
                        {
                            int[] case3Array = { 2, 1, 7, 4, 9, 5 }; //place holder until I can take user input and make it an array of numbers
                            Console.WriteLine("");
                            Console.WriteLine(Numbers.BiggestNumber(case3Array));
                            break;
                        }
                    case "4":
                        {
                            int[] case4Array = { 2, 1, 7, 4, 9, 5 }; //place holder until until I can take user input and make it an array of numbers
                            Console.WriteLine(Numbers.SecondBiggestNumber(case4Array));
                            break;
                        }
                    case "5":
                        {
                            int[] case5Array = { 2, 4, 6, 9 }; //place holder until until I can take user input and make it an array of numbers

                            if (Numbers.ContainsOddNumber(case5Array) > 0)
                                Console.WriteLine("There is an odd number in the array");
                            else if (Numbers.ContainsOddNumber(case5Array) == 0)
                                Console.WriteLine("There are no odd numbers in the array");
                            break;
                        }
                    case "6":
                        {
                            string case6String = Console.ReadLine();
                            Console.WriteLine(Words.RemoveVowels(case6String));
                            break;
                        }
                    case "7":
                        {
                            int[] case7Array = { -1, 2, 4, 6, 9 }; //palce holder until I learn to take user input and change it ito an array 
                            Console.WriteLine(Numbers.HowManyPositiveAndNegative(case7Array));
                            break;
                        }
                    case "8":
                        {
                            Console.WriteLine("We are going to give you the average of a group of numbers\n");
                            Console.WriteLine("Please enter the first number");
                            double num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter the second number");
                            double num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter the third number");
                            double num3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter the fourth number");
                            double num4 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter the final number");
                            double num5 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"The average of {num1}, {num2}, {num3}, {num4}, and {num5} is {(num1 + num2 + num3 + num4 + num5)/5}");
                            break;
                        }
                    case "9":
                        {
                            Console.WriteLine("Enter a a sentence and I will tell you what the longest word is");
                            string case9Sring = Console.ReadLine(); 
                            Console.WriteLine($"\nThe longest word in the sentence is \"{Words.LongestWord(case9Sring).ToUpper()}\"\n");
                            break;
                        }
                    case "0":
                        {
                            Console.WriteLine("Thank you...Goodbye.\n");
                            switchOnOff = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Selection\nPlease try again.\n");
                            break;
                        }
                }
            }

            Console.WriteLine(Words.RemoveVowel("Hello World"));

        }
    }
}
