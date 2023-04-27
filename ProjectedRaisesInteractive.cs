// Convert the ProjectedRaises class to an interactive application named
// ProjectedRaisesInteractive. Instead of assigning values to the salaries, accept them
// from the user as input.

using System;
class ProjectedRaisesInteractive
{
    static void Main()
    {
        double raise;
        string employee1, employee2, employee3;
        int salary1, salary2, salary3;

        raise = 1.40;

        employee1 = "John";
        employee2 = "Flora";
        employee3 = "Winnie";

        Console.Write("What is the salary of John? -> ");
        salary1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("What is the salary of Flora? -> ");
        salary2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("What is the salary of Winnie? -> ");
        salary3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Thank you!");
        Console.WriteLine();

        Console.WriteLine("The salary for {0} will be {1} next year!", employee1, (raise * salary1).ToString("C"));
        Console.WriteLine();
        Console.WriteLine("The salary for {0} will be {1} next year!", employee2, (raise * salary2).ToString("C"));
        Console.WriteLine();
        Console.WriteLine("The salary for {0} will be {1} next year!", employee3, (raise * salary3).ToString("C"));
    }
}
