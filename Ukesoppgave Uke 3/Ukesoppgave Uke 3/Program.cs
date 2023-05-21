using Ukesoppgave_Uke_3;

internal class Program
{
    private static readonly List<Pet> pets = new()
    {
        new Pet("Luna", "Katt", 3, 5, 2, "tunfisk"),
        new Pet("Balder", "Hund", 6, 8, 3, "kjøttboller"),
        new Pet("Nemo", "Fisk", 1, 3, 1, "algemix")
    };

    private static void Main(string[] args)
    {
        Console.WriteLine("Pet Simulator 4000");
        MainMenu();
    }

    public static void MainMenu()
    {
        Console.WriteLine("Velg et kjæledyr:");
        Console.WriteLine("1. Luna (Katt)");
        Console.WriteLine("2. Balder (Hund)");
        Console.WriteLine("3. Nemo (Fisk)");
        var petChoice = Console.ReadLine();

        if (petChoice == "1" || petChoice == "2" || petChoice == "3")
        {
            var choice = Convert.ToInt32(petChoice);
            var pet = pets[choice - 1];
            PetMenu(pet);
        }
        else
        {
            Console.WriteLine("Ugyldig valg. Prøv igjen.");
            Console.Clear();
            MainMenu();
        }
    }

    public static void PetMenu(Pet pet)
    {
        Console.WriteLine($"Du har valgt {pet.Name}, en {pet.Type}.");
        Console.WriteLine("Velg en handling:");
        Console.WriteLine("1. Mate");
        Console.WriteLine("2. Leke");
        var actionChoice = Console.ReadLine();

        if (actionChoice == "1")
        {
            Console.WriteLine("Velg mat:");
            Console.WriteLine("1. Tunfisk");
            Console.WriteLine("2. Kjøttboller");
            Console.WriteLine("3. Algemix");
            var foodChoice = Console.ReadLine();
            var food = GetFoodChoice(foodChoice);
            pet.Eat(food);
        }
        else if (actionChoice == "2")
        {
            pet.Play();
            Console.WriteLine($"Du lekte med {pet.Name}. Lykkeligheten har økt.");
        }
        else
        {
            Console.WriteLine("Ugyldig valg. Prøv igjen.");
        }

        Console.WriteLine($"Sultnivå: {pet.Hunger}");
        Console.WriteLine($"Lykkelighetsnivå: {pet.Happiness}");

        Console.WriteLine("Trykk en tast for å fortsette...");
        Console.ReadKey();
        Console.Clear();
        MainMenu();
    }

    public static string GetFoodChoice(string foodChoice)
    {
        switch (foodChoice)
        {
            case "1":
                return "tunfisk";
            case "2":
                return "kjøttboller";
            case "3":
                return "algemix";
            default:
                return "";
        }
    }
}