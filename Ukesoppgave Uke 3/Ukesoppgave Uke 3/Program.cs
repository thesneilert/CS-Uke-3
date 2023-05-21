using Ukesoppgave_Uke_3;

internal class Program
{
    
    
    private static List<Pet> pet = new()
    {
        new Pet("arne", "katt", 20, 10, 1)
    };

    private static void Main(string[] args)
    {
        Console.WriteLine("Pet Simulator 4000");
        MainMenu();
    }

    public static void MainMenu()
    {
        Console.WriteLine("Trykk 1");
        var menyChoose = Console.ReadLine();

        if (menyChoose == "1")
        {
            
        }
        else
        {
            Console.WriteLine("Ugyldig valg. Prøv igjen.");
            Console.Clear();
        }
    }
}

// public static void MainMenu2()
// {
//     Console.WriteLine("gjør dyret glad");
//     Console.WriteLine();
//     pet[0].happyPlus();
//     Console.WriteLine($"{pet[0].Happiness}");
//         
//     Console.WriteLine("bytt navn:");
//     var navn = Console.ReadLine();
//     pet[0].changeName(navn);
//     Console.WriteLine($"{pet[0].Name}");
// }