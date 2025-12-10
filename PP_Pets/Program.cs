namespace PP_Pets
{
    internal class Program
    {
        static List<Pet> pets;
        private static Pet chosenPet;
        
        static void Main()
        {
             pets = new List<Pet>
            {
                new Pet("Kåre", true, false, false),
                new Pet("Pål", true, false, false),
            };
            run();
        }

        public static void run()   
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
                    chosenPet = pets[0];
                    chosenPet.CareForPet();  // Katt
                    break;

                case "2":
                    chosenPet = pets[1];
                    chosenPet.CareForPet(); // Hund
                    break;
                default:
                    Console.WriteLine("dette er ikke et input, velg 1 eller 2");
                    run();
                    break;
            }
        }
    }
}


