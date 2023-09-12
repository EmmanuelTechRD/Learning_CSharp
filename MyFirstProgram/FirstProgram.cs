using System.Transactions;

internal class FirstProgram
{
    private static void Main(string[] args)
    {
        /*// First (Hello C#) exercise:
        Console.Write("Please enter your name: ");
        var aName = Console.ReadLine();
        Console.WriteLine($"Hello, {aName}!");*/

        // Assignment #1:
        
        // Exercise #1:
        // Comment this line using a single line comment.
        
        // Exercise #2:
        /*Comment this and the next line using multiline comment.
        VSCode will show us an error if we don't comment regular text*/

        // Exercise #3:
        // Write a C# Statement to print your name to the console:
        Console.WriteLine("Emmanuel Soto");

        // Assignment #2 (stringFun):

        // Different ways to represent strings.
        // Literals:
        string literalSTR = "This a regular string of text.";
        Console.WriteLine(literalSTR);

        // Verbatim:
        string verbatimSTR = @"C:\Users\Emmanuel STech\Documents\Coding\LearningC#\MyTestText.txt";
        Console.WriteLine(verbatimSTR);

        // Interpolated:
        string leMonde = "le Monde";
        string interpolatedSTR = $"Bonjour {leMonde}";
        Console.WriteLine(interpolatedSTR);
    }
}