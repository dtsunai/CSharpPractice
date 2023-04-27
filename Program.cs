//Write a program named TestsInteractive that prompts a user for eight test scores and
//displays the average of the test scores to two decimal places.

using System;
class TestsInteractive
{
    static void Main()
    {
        double score, sum, average;
        int counter;

        counter = 0;
        sum = 0;

        Console.WriteLine("Welcome to the Test Average Calculator!");
        Console.WriteLine("Please input eight scores. . .");
        Console.WriteLine();

        while (counter <= 7)
        {
            counter += 1;
            Console.Write("Score {0}: ", counter);
            score = Convert.ToDouble(Console.ReadLine());
            sum = sum + score;
        }
        Console.WriteLine();

        average = (sum / counter);
        Console.WriteLine("The test average of the class is: {0}", average.ToString("F2"));
    }
}