namespace PP_Pets
{
    internal class Program
    {
        static List<Pet> pets;
       
        
        static void Main(string[] args)
        {
             pets = new List<Pet>
            {
                new Pet("Cat", true, false, false),
                new Pet("Dog", true, false, false),
            };
            run();
        }
        
        static void run()   
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
                    pets[0].CareForPet();
                    break;

                case "2":
                    pets[1].CareForPet();
                    break;
                default:
                    Console.WriteLine("dette er ikke et input, velg 1 eller 2");
                    run();
                    break;
            }
        }
    }
}


