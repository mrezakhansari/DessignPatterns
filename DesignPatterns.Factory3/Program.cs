

using DesignPatterns.Factory3;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please Enter :  Add | Subtract | Divide | Multiply");
        CalculateFactory calculateFactory = new CalculateFactory();
        ICalculate obj1 = calculateFactory.GetCalculation(Console.ReadLine());
        obj1.Calculate(10, 5);

    }
}