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
    void addPet()
    {
        List<Pet> pets = new List<Pet>();

        Pet cat = new Pet("Cat", true, false, false);
        Pet dog = new Pet("Dog", true, false, false);

        pets.Add(cat);
        pets.Add(dog);
    }

    //public static void addPet(List<Pet> _Pets)
    //{
    //    _Pets = [];
    //}

    public void run()
    {
        Console.WriteLine("Velg et kjæledyr");
        Console.WriteLine("""
                          CTRL + C to exit
                          1. Katt
                          2. Hund
                          """);
        string input1 = Console.ReadLine();
        switch (input1)
            {
                case "1":
                    CareForPet(1);
                    break;

                case "2":
                    CareForPet(2);
                    break;
                default: 
                    Console.WriteLine("dette er ikke et input, velg 1 eller 2");
                    run();
                    break;
            }
        }
    }


    public static void CareForPet(int chosenPet)
    {
        addPet();

        if (chosenPet == 1)
        {
            pets.cat;
        }else if (chosenPet == 2)
        {
            var currentpet = pets.cat;
        }
        else
        {
            Console.WriteLine("dette er ikke et input, velg 1,2 eller 3");
            CareForPet(chosenPet);
        }

        Console.WriteLine("Velg handling for kjæledyret");
        Console.WriteLine("""
                          CTRL + C to exit
                          1. Gi Mat
                          2. Kos med
                          3. Gå tur
                          """);
        var input2 = Console.ReadLine();
        switch (input2)
        {
            case "1":
                //metode til å skjekke om sulten / endre true/fasle på Hunger oi
                break;

            case "2":
                //Metode for å gjøre glad
                break;
            case "3":
                //Metode for å 
                break;
            default:
                Console.WriteLine("dette er ikke et input, velg 1,2 eller 3");
                run();
                break;
    }

}