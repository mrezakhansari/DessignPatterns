// See https://aka.ms/new-console-template for more information
using DesignPatterns.Singleton;

internal class Program
{
    static TableServers hostList1 = TableServers.GetTableServers();
    static TableServers hostList2 = TableServers.GetTableServers();

    private static void Main(string[] args)
    {
        for (int i = 0; i < 4; i++)
        {
            Host1GetNextServer();
            Host2GetNextServer();
        }
        Console.WriteLine(hostList1.GetHashCode());
        Console.WriteLine(hostList2.GetHashCode());

        // baraye esbate eenke har do yejaye az memory hastand. va chand ta obj nadarim :

        Console.WriteLine("Singleton ------------------------------");
        Logger obj1 = Logger.GetInstance();
        Logger obj2 = Logger.GetInstance();
        Console.WriteLine(obj1.GetHashCode());
        Console.WriteLine(obj1.GetHashCode());

        Console.WriteLine("Singleton ------------------------------");
        Logger2 obj3 = Logger2.Instance;
        Logger2 obj4 = Logger2.Instance;
        Console.WriteLine(obj3.GetHashCode());
        Console.WriteLine(obj4.GetHashCode());

        Console.WriteLine("Non Singleton --------------------------");
        Test obj5 = new Test();
        Test obj6 = new Test();
        Console.WriteLine(obj5.GetHashCode());
        Console.WriteLine(obj6.GetHashCode());

    }
    private static void Host1GetNextServer() => Console.WriteLine("The next server is:" + hostList1.NextServer());

    private static void Host2GetNextServer() => Console.WriteLine("The next server is:" + hostList2.NextServer());
}