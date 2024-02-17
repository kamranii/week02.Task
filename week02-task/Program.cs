using System;

namespace week02_task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 2-1
            ////Get inputs from the user
            //int smaller = 0;
            //int ebob = 0;
            //Console.WriteLine("Please provide the first number: ");
            //string strFirstNumb = Console.ReadLine();
            //int firstNumber = int.Parse(strFirstNumb);
            //Console.WriteLine("Please provide the second number: ");
            //string strSecondNumb = Console.ReadLine();
            //int secondNumber = int.Parse(strSecondNumb);
            //if (firstNumber >= secondNumber)
            //{
            //    smaller = secondNumber;
            //}
            //else if(secondNumber > firstNumber)
            //{
            //    smaller = firstNumber;
            //}
            //for (int i = smaller; i >= 1; i--)
            //{
            //    if(firstNumber % i == 0 && secondNumber % i == 0)
            //    {
            //        ebob = i;
            //        break;
            //    }
            //}
            //Console.WriteLine(ebob);
            #endregion
            #region Task 2-2
            //    //Declare an array of integers
            //    int[] numbers = { 7, 10, 14, 17, 19, 22, 30, 46 };
            //    Console.WriteLine("Sum of our odd integers is: " + Sum_of_OddNumbers(numbers));
            //    #endregion
            //}
            //static public int Sum_of_OddNumbers(int[] numbers)
            //{
            //    int sum = 0;
            //    for(int i = 0; i < numbers.Length; i++)
            //    {
            //        if(numbers[i] % 2 != 0)
            //        {
            //            sum += numbers[i];
            //        }
            //    }
            //    return sum;
            //}
            #endregion
            #region Week02-Hometask
            ////Ask for the input
            //Console.WriteLine("Please input a string: ");
            //string input_string = Console.ReadLine();
            ////Print out the result
            //Console.WriteLine($"{input_string} contains {space_count(input_string)} spaces");
            //Console.WriteLine($"The type of our result is {space_count(input_string).GetType()}");
            ////Function to count "spaces"
            //static int space_count (string input_string)
            //{
            //    int number_of_spaces = 0;
            //    //Loop to find "spaces"
            //    for(int i = 0; i < input_string.Length; i++)
            //    {

            //        if (input_string[i].Equals(' '))
            //        {
            //            number_of_spaces++;
            //        }
            //    }
            //    return number_of_spaces;
            //}
            #endregion
            #region Week02-02-1
            ////Ask for the input
            //Console.WriteLine("Please provide an input: ");
            //var input = Console.ReadLine();
            ////Output the result

            //try
            //{
            //    Console.WriteLine($"{int.Parse(input)}");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Please provide a valid input");

            //}
            #endregion
            #region Week02-02-2
            //int[] numbers = new int[5];
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = i + 1;
            //    Console.WriteLine(numbers[i]);
            //}
            //foreach(int i in numbers)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Week02-02-3
            ////Ask the user for an input number
            //Console.WriteLine("Please provide a number to divide by zero: ");
            //int input_number = int.Parse(Console.ReadLine());
            //int dividend = 0;
            //int undefined;
            //try
            //{
            //    undefined = input_number / dividend;
            //}
            //catch (DivideByZeroException)
            //{
            //    undefined = input_number / 4;
            //    Console.WriteLine(undefined);
            //}
            //finally
            //{
            //    Console.WriteLine("You have been trying to divide by zero");
            //}
            #endregion
            string[] letter = { "Turxay", "Perviz", "Cavid" };
            Array.Sort(letter);
            Console.WriteLine($"{Array.BinarySearch<>}");
        }

    }
}
