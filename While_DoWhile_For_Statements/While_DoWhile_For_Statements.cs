using System.Transactions;

internal class While_DoWhile_For_Statements
{
    private static void Main(string[] args)
    {
        // While_DoWhile_For_Statements:
        
        int input;

        Console.WriteLine("Enter a number:");
        input = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine("While loop");
        int i = 0;
        while(i < input) // While loop.
        {
            Console.WriteLine(i);
            i++;
        }

        // Space.

        Console.WriteLine("Do_While loop");
        i = 0; // Making "i" zero again.
        do // Do_While loop.
        {
            Console.WriteLine(i);
            i++;
        } while(i < input);

        // Space.

        Console.WriteLine("For loop");
        for(int e = 0; e < input; e++) // For loop.
        {
            Console.WriteLine(e);
        }
        Console.WriteLine("");
        Console.WriteLine("");

        // Space.

        // For each statements demo:

        string[] days = new string[]
        {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"
        };

        foreach(string s in days)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine("End of the program.");

    }
}