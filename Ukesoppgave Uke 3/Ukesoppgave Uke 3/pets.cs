namespace Ukesoppgave_Uke_3;

public class Pet
{
    public string Name { get; private set; }
    public string Type { get; private set; }
    public int Age { get; private set; }
    public int Happiness { get; private set; }
    public int Hunger { get; private set; }
    
    public Pet(string name, string type, int age, int happiness, int hunger)
    {
        Name = name;
        Type = type;
        Age = age;
        Happiness = happiness;
        Hunger = hunger;
    }

    public void eat()
    {
        if ()
        {
        Hunger += 1
        }
        else ()
        {
        Hunger += 2    
        }
    }

    public void play()
    {
        Happiness += 1
    }
}

//     public void happyPlus()
//     {
//         Happiness++;
//     }
//
//     public void changeName(string x)
//     {
//         Name = x;
//     }

//     public void kjørcmd(string cmd)
//     {
//         switch (cmd)
//         {
//             case"lek":
//                 Console.WriteLine("leker");
//                 break;
//         }
//     }

