using System.Transactions;

internal class SwitchStatements
{
    private static void Main(string[] args)
    {
        // SwitchStatements:
        char ch;

        Console.Write("Enter the first letter of your favorite car brand: ");
        ch = (char)Console.Read();

        switch(ch){
            case 't':
            {
                Console.WriteLine("Your favorite car brand is Toyota. ¡Eso aguanta to'!");
                break;
            }
            case 'h':
            {
                Console.WriteLine("Your favorite car brand is Honda. El favorito de los chperos...");
                break;
            }
            case 'n':
            {
                Console.WriteLine("Your favorite car brand is Nissan. Carro de gente seria y de los Ubers.");
                break;
            }
            default:
            {
                Console.WriteLine("Either you don't have any favorite cars or you are Hyundero.");
                break;
            }
        }

    }
}