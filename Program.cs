//Write a program named Twitter that accepts a user’s message and determines
//whether it is short enough for a social networking service that does not accept
//messages of more than 140 characters.

using System;
class Twitter
{
    static void Main()
    {
        string input, like, comment, share;

        like = "Like";
        comment = "Comment";
        share = "Share";

        Console.WriteLine("Welcome to Twitter!");
        Console.Write("What's happening? ");
        input = Console.ReadLine();

        if (input.Length > 140)
        {
            Console.WriteLine("\nMessage exceeds 140 characters.");
            Console.WriteLine("Your post had {0} too many characters. Please close this window to try again.", input.Length - 140);
        }
        else
        {
            Console.WriteLine("\nPost created!");
            Console.WriteLine("User: {0}", input);

            Console.WriteLine("\n{0,-10}{1,6}{2, 11}", like, comment, share);
        }
    }
}