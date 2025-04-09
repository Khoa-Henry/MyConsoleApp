class Program
{
    private static FileOutput outFile = new FileOutput("animals.txt");

    private static FileInput inFile = new FileInput("animals.txt");

    static void Main(string[] args)
    {
        List<Talkable> zoo =
        [
            new Dog(true, "Bean"),
            new Cat(9, "Charlie"),
            new Teacher(44, "Stacy Read"),
        ];

        AddNewAnimals(zoo);

        foreach (Talkable thing in zoo)
        {
            PrintOut(thing);
        }
        outFile.FileClose();

        inFile.FileRead();
        inFile.FileClose();

        FileInput indata = new FileInput("animals.txt");
        string line;
        while ((line = indata.FileReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }

    static void PrintOut(Talkable p)
    {
        outFile.FileWrite(p.Name + " | " + p.Talk());
        Console.WriteLine(p.Name + " says = " + p.Talk());
    }

    static void AddNewAnimals(List<Talkable> zoo)
    {
        while (true)
        {
            Console.WriteLine(
                "What type of animal do you want to create? (Dog, Cat, Teacher, or type 'exit' to finish):"
            );
            string animalType = Console.ReadLine();

            if (animalType.ToLower() == "exit")
            {
                break;
            }

            switch (animalType.ToLower())
            {
                case "dog":
                    Console.WriteLine("Is the dog trained? (true/false):");
                    bool isTrained = bool.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the dog's name:");
                    string dogName = Console.ReadLine();
                    zoo.Add(new Dog(isTrained, dogName));
                    break;

                case "cat":
                    Console.WriteLine("Enter the cat's number of lives:");
                    int lives = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the cat's name:");
                    string catName = Console.ReadLine();
                    zoo.Add(new Cat(lives, catName));
                    break;

                case "teacher":
                    Console.WriteLine("Enter the teacher's age:");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the teacher's name:");
                    string teacherName = Console.ReadLine();
                    zoo.Add(new Teacher(age, teacherName));
                    break;

                default:
                    Console.WriteLine("Invalid animal type. Please try again.");
                    break;
            }
        }
    }
}
