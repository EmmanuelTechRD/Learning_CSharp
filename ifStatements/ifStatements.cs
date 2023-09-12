using System.Transactions;

internal class ifStatements
{
    private static void Main(string[] args)
    {
        // ifStatements:
        char ch;

        Console.Write("Enter the first letter of your favorite car brand: ");
        ch = (char)Console.Read();

        if(ch == 't' || ch == 'T'){
            Console.WriteLine("Your favorite car brand is Toyota. ¡Eso aguanta to'!");
        }
        else if(ch == 'h' || ch == 'H'){
            Console.WriteLine("Your favorite car brand is Honda. El favorito de los chperos...");
        }
        else if(ch == 'n' || ch == 'N'){
            Console.WriteLine("Your favorite car brand is Nissan. Carro de gente seria y de los Ubers.");
        }
        else{
            Console.WriteLine("Either you don't have any favorite cars or you are Hyundero.");
        }

    }
}