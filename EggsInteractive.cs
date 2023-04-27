//Modify the Eggs program to create a new one named EggsInteractive that prompts
//the user for and accepts a number of eggs for each chicken.

using System;
class EggsInteractive
{
    static void Main()
    {
        int egg1, egg2, egg3, egg4;
        int eggTotal, dozen, single;

        Console.Write("How many eggs did Nora lay? -> ");
        egg1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("How many eggs did Bora lay? -> ");
        egg2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("How many eggs did Lora lay? -> ");
        egg3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("How many eggs did Sora lay? -> ");
        egg4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        eggTotal = egg1 + egg2 + egg3 + egg4;
        dozen = eggTotal / 12;
        single = eggTotal % 12;

        Console.WriteLine("Chicken 1: Nora laid {0} eggs!", egg1);
        Console.WriteLine("Chicken 2: Bora laid {0} eggs!", egg2);
        Console.WriteLine("Chicken 3: Lora laid {0} eggs!", egg3);
        Console.WriteLine("Chicken 4: Sora laid {0} eggs!", egg4);
        Console.WriteLine();

        Console.WriteLine("In February, these four chickens laid a total of {0} eggs!", eggTotal);
        Console.WriteLine("In {0} eggs, there are {1} dozen and {2} eggs.", eggTotal, dozen, single);
    }
}
