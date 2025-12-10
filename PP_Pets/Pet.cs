namespace PP_Pets;

internal class Pet
{
    private List<Pet> _Pets;

    public void addPet()
    {
        _Pets = [];
    }

    public static void run()
    {
        Console.WriteLine("Velg handling for kjøledyret");
        Console.WriteLine("""
                          CTRL + C to exit
                          1. handling 1
                          2. handling 2
                          3. handling 3
                          """);
    }
    

}