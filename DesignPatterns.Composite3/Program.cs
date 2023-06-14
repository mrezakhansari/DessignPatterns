using DesignPatterns.Composite3;

public class Program
{
    private static void Main(string[] args)
    {
        IData file1 = new DesignPatterns.Composite3.File("file1.txt",1);
        IData file2 = new DesignPatterns.Composite3.File("file2.txt",1);
        IData file3 = new DesignPatterns.Composite3.File("file3.txt",2);
        IData file4 = new DesignPatterns.Composite3.File("file4.txt",3);
        IData file5 = new DesignPatterns.Composite3.File("file5.txt",3);
        IData file6 = new DesignPatterns.Composite3.File("file6.txt",3);
        IData file7 = new DesignPatterns.Composite3.File("file7.txt",3);

        DesignPatterns.Composite3.Directory directory11 = new DesignPatterns.Composite3.Directory("directory11",2);
        directory11.AddChild(file4);

        DesignPatterns.Composite3.Directory directory1 = new DesignPatterns.Composite3.Directory("directory1",1);
        directory1.AddChild(directory11);
        directory1.AddChild(file3);

        DesignPatterns.Composite3.Directory directory21 = new DesignPatterns.Composite3.Directory("directory21",2);
        directory21.AddChild(file5);
        directory21.AddChild(file6);

        DesignPatterns.Composite3.Directory directory22 = new DesignPatterns.Composite3.Directory("directory22", 2);
        directory22.AddChild(file7);

        DesignPatterns.Composite3.Directory directory2 = new DesignPatterns.Composite3.Directory("directory2", 1);
        directory2.AddChild(directory21);
        directory2.AddChild(directory22);

        DesignPatterns.Composite3.Directory rootDirectory = new DesignPatterns.Composite3.Directory("rootDirectory",0);
        rootDirectory.AddChild(file1);
        rootDirectory.AddChild(directory1);
        rootDirectory.AddChild(file2);
        rootDirectory.AddChild(directory2);

        rootDirectory.Print();

        Console.ReadLine();


    }
}