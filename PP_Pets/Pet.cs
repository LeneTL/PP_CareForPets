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
    

    //public static void addPet(List<Pet> _Pets)
    //{
    //    _Pets = [];
    //}

    


    public void CareForPet()   
    {


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
                //Metode for å gå tur
                break;
            default:
                Console.WriteLine("dette er ikke et input, velg 1,2 eller 3");
                CareForPet();
                break;
        }
    }

}