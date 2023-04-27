//Create an enumeration named Month that holds values for the months of the year,
//starting with JANUARY equal to 1. Write a program named MonthNames that prompts
//the user for a month integer. Convert the user’s entry to a Month value, and display it.

using System;
class MonthNames
{
    enum Month
    {
        January = 1, February, March, April, May, June,
        July, August, September, October, November, December
    }
    static void Main ()
    {
        int monthInput;
        Month monthOutput;

        Console.Write("Please enter a number from 1-12 to view its corresponding month: ");
        monthInput = Convert.ToInt32(Console.ReadLine());

        monthOutput = (Month)monthInput;

        Console.WriteLine("\nThe month that corresponds to {0} is {1}!", monthInput, monthOutput);
    }
}
