using System.Transactions;

internal class ArraysFunProgram
{
    private static void Main(string[] args)
    {
        // ArraysFunProgram:
        string[] months = new string[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"
        }; // First way to declare an Array.
        Console.WriteLine(months[9]); // Printing the element in the index position "9" counting from "0".

        // Second way to declare an Array:
        string[] newMonths;
        newMonths = new string[12];
        newMonths[0] = "January";
        newMonths[1] = "February";
        newMonths[2] = "March";
        newMonths[3] = "April";
        newMonths[4] = "May";
        newMonths[5] = "June";
        newMonths[6] = "July";
        newMonths[7] = "August";
        newMonths[8] = "September";
        newMonths[9] = "October";
        newMonths[10] = "November";
        newMonths[11] = "December";

        // Printing the elements of the string[] "newMonths" array:
        Console.WriteLine(newMonths[0]);
        Console.WriteLine(newMonths[1]);
        Console.WriteLine(newMonths[2]);
        Console.WriteLine(newMonths[3]);
        Console.WriteLine(newMonths[8]);
        Console.WriteLine(newMonths[9]);
        Console.WriteLine(newMonths[10]);
        Console.WriteLine(newMonths[11]);
    }
}