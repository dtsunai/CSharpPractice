//Convert the InchesToCentimeters program to an interactive application named InchesToCentimeterslnteractive.
//Instead of assigning a value to the inches variable,accept the value from the user as input.

using System;
class InchesToCentimetersInteractive
{
    static void Main()
    {
        const double centimetersConversion = 2.54;
        double givenInch;

        Console.WriteLine("There are 2.54 centimeters in 1 inch.");
        Console.Write("Please enter a number for inches to convert into centimeters: -> ");
        givenInch = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("In {0} inches, there are {1} centimeters!", givenInch, (centimetersConversion * givenInch).ToString("F2"));
    }
}
