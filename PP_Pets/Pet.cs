using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace PP_Pets;

internal class Pet
{
    public string Name { get; set; }
    public bool Hunger { get; set; }
    public bool Happyness { get; set; }
    public bool Walkies { get; set; } // toalett


    public Pet(string name, bool hunger, bool happyness, bool walkies)
    {
        Name = name;
        Hunger = hunger;
        Happyness = happyness;
        Walkies = walkies;
    }

    public void CareForPet()
    {

        Console.WriteLine("Velg handling for kjæledyret");
        Console.WriteLine("""
                          CTRL + C to exit
                          1. Gi Mat
                          2. Kos med
                          3. Gå tur
                          4. Si hadet
                          """);
        var input2 = Console.ReadLine();
        switch (input2)
        {
            case "1":
                GiveFood();
                break;

            case "2":
                //Metode for å gjøre glad
                PetPet();
                break;
            case "3":
                //Metode for å gå tur
                WalkPet();
                break;
            case "4":
                //return to Main;
                Program.run();
                break;
            default:
                Console.WriteLine("dette er ikke et input, velg 1,2,3 eller 4");
                CareForPet();
                break;
        }
    }

    public void GiveFood()
    {
        if (Hunger)
        {
            Console.WriteLine($"Du mater {Name}");
            Hunger = false;
            Walkies = true;
        }
        else
        {
            Console.WriteLine($"{Name} er ikke sulten!");
        }

        CareForPet();
    }

    public void PetPet()
    {
        if (Happyness)
        {
            Console.WriteLine($"{Name} trenger ikke kos");
        }
        else
        {
            Console.WriteLine($"{Name} blir glad over kosen!");
            Happyness = true;
        }
        CareForPet();
    }

    public void WalkPet()
    {
        if (Walkies)
        {
            Console.WriteLine($"{Name} trengte å gå tur");
            Walkies = false;
            Hunger = true;
        }
        else
        {
            Console.WriteLine($"{Name} vil ikke på tur!");
        }
        CareForPet();
    }
}