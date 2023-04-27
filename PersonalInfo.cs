//Write, compile, and test a program named PersonalInfo that displays a person’s name, birthdate, work phone number, and cell phone number.

using System;
class PersonalInfo
{
    static void Main()
    {
        string fullName;
        string birthDate;
        string workPhone;
        string cellPhone;

        Console.Write("What's your full name? -> ");
        fullName = Console.ReadLine();

        Console.Write("What's your birthday? (mm/dd/yyyy) -> ");
        birthDate = Console.ReadLine();

        Console.Write("What's your workphone? (###-###-####) -> ");
        workPhone = Console.ReadLine();

        Console.Write("What's your cellphone? -> ");
        cellPhone = Console.ReadLine();

        Console.WriteLine(" ");

        Console.WriteLine("Your name: " + fullName);
        Console.WriteLine("Your birthday: " + birthDate);
        Console.WriteLine("Your workphone: " + workPhone);
        Console.WriteLine("Your cellphone: " + cellPhone);
    }
}
