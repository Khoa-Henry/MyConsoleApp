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
}
