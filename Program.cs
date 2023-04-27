//Malcolm Movers charges a base rate of $200 per move plus $150 per hour and $2 per
//mile.Write a program named MoveEstimator that prompts a user for and accepts
//estimates for the number of hours for a job and the number of miles involved in the
//move and displays the total moving fee.

using System;
class MoveEstimator
{
    static void Main()
    {
        double baseRate, perHour, perMile, hour, mile;

        baseRate = 200;
        perHour = 150;
        perMile = 2;

        Console.WriteLine("Hi, welcome to Malcom Movers Move Estimator!");
        Console.WriteLine("Congratulations on your new move! We'll need a few details about your situation before we give you an estimate.");
        Console.WriteLine();

        Console.Write("First, enter an estimate for how many hours the move may take: ");
        hour = Convert.ToDouble(Console.ReadLine());

        Console.Write("Next, enter how many miles will be required to move between locations: ");
        mile = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Based on Malcom Movers Move Estimator, the cost of your move will be: {0}", (baseRate + (perHour * hour) + (perMile * mile)).ToString("C"));
    }
}