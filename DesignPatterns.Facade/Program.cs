

using DesignPatterns.Facade;
using System.Xml.Serialization;

public class Program
{
    private static void Main(string[] args)
    {
        Int32 choice = 0;
        do
        {
            Console.WriteLine("========== Mobile Shop ========= \n");
            Console.WriteLine("             1. IPHONE.           \n");
            Console.WriteLine("             2. SAMSUNG.           \n");
            Console.WriteLine("             3. BLACKBERRY.           \n");
            Console.WriteLine("             4. EXIT.           \n");
            Console.WriteLine("Enter your choice");

            choice = Convert.ToInt32(Console.ReadLine());
            ShopKeeper sk = new ShopKeeper();

            switch (choice)
            {
                case 1:
                    sk.IPhoneSale();
                    break;
                case 2:
                    sk.SamsungSale();
                    break;
                case 3:
                    sk.BlackBerrySale();
                    break;
                default:
                    Console.WriteLine("Nothing You purchased");
                    break;
            }
        } while (choice != 4);

        Console.ReadLine();
    }
}