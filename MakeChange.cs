//Write a program named MakeChange that calculates and displays the conversion of
//an entered number of dollars into currency denominations—twenties, tens, fives, and
//ones. For example, $113 is 5 twenties, 1 ten, 0 fives, and 3 ones. 

using System;
class MakeChange
{
    static void Main()
    {
        int amount, twenty, ten, five, one;
        string catAmount, catBill, catBillTwenty, catBillTen, catBillFive, catBillOne;

        catAmount= "Amount";
        catBill = "Bill Type";
        catBillTwenty = "$20";
        catBillTen = "$10";
        catBillFive = "$5";
        catBillOne = "$1";
        
        Console.WriteLine("Welcome to MakeChange!");
        Console.Write("Please enter an amount to count the amount of $20, $10, $5 and $1 bills: ");

        amount = Convert.ToInt32(Console.ReadLine());
        twenty = (amount / 20);
        ten = ((amount % 20) / 10);
        five = ((amount % 10) / 5);
        one = ((amount % 5) / 1);

        Console.WriteLine();
        Console.WriteLine("You have {0} $20 bills!", twenty);
        Console.WriteLine("You have {0} $10 bills!", ten);
        Console.WriteLine("You have {0} $5 bills!", five);
        Console.WriteLine("You have {0} $1 bills!", one);
        Console.WriteLine();

        Console.WriteLine("{0,-8}{1,-8}", catAmount,catBill);
        Console.WriteLine("{0,-8}{1,-8}", "------", "---------");
        Console.WriteLine("{0,-8}{1,-8}", twenty, catBillTwenty);
        Console.WriteLine("{0,-8}{1,-8}", ten, catBillTen);
        Console.WriteLine("{0,-8}{1,-8}", five, catBillFive);
        Console.WriteLine("{0,-8}{1,-8}", one, catBillOne);
        Console.WriteLine("{0,-8}{1,-8}", "------", "---------");
    }
}
