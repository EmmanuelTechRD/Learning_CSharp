using System.Transactions;

internal class Debugging
{
    static void Main(string[] args)
    {
        // Debugging:
        // First exercise: print all even numbers between 1 and 10:
        PrintEvenNumbers();

    }

    static void PrintEvenNumbers()
    {
        int input, i;
        input = 10;
        i = 1;

        while (i < input)
        {
            bool result = ((i % 2) == 0);
            if (result)
            {
                // Finding an even number and printing it.
                Console.WriteLine(i);
            }
            i++;
        }
    }
}