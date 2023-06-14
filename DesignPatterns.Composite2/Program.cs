using DesignPatterns.Composite2;

public class Program
{
    private static void Main(string[] args)
    {
        Developer dev1 = new Developer(100,"Mohammadreza","Pro Developer");
        Developer dev2 = new Developer(101,"Gholami","Developer");
        CompanyDirectory engDirectory = new CompanyDirectory();
        engDirectory.AddEmployee(dev1);
        engDirectory.AddEmployee(dev2);

        Manager man1 = new Manager(200, "MAdahi", "SEO Manager");
        Manager man2 = new Manager(201, "GoolGooli", "Project MAnager");
        CompanyDirectory accDirectory = new CompanyDirectory();
        accDirectory.AddEmployee(man1);
        accDirectory.AddEmployee(man2);

        CompanyDirectory directory = new CompanyDirectory();
        directory.AddEmployee(engDirectory);
        directory.AddEmployee(accDirectory);
        directory.ShowEmployeeDetails();

        Console.ReadLine(); 
    }
}