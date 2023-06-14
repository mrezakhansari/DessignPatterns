
using DesignPatterns.Proxy;

public class Program
{
    private static void Main(string[] args)
    {
        DesignPatterns.Proxy.Browser browser = new DesignPatterns.Proxy.Browser();
        browser.SendRequest();

        Console.ReadLine();
    }
}