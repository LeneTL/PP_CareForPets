using System.Text.RegularExpressions;

namespace PP_Pets;

internal class Pet
{
    public string Name { get; set; }
    public string Hunger { get; set; }
    public bool Happyness { get; set; }

    public string Walkies { get; set; } // toalett


    public Pet(string name, string hunger, bool happyness, string walkies)
    {
        Name = name;
        Hunger = hunger;
        Happyness = happyness;
        Walkies = walkies;
    }
    public static void addPet()
    {
        addPet();
    }

    public static void addPet(List<Pet> _Pets)
    {
        _Pets = [];
    }

    public void run()
    {
        Console.WriteLine("Velg handling for kjøledyret");
        Console.WriteLine("""
                          CTRL + C to exit
                          1. handling 1
                          2. handling 2
                          3. handling 3
                          """);

        var input = Console.ReadLine();
        switch (input)
        {
            case "1":
                addPet();
                break;

          //  case "2":


        }





    }
    

}