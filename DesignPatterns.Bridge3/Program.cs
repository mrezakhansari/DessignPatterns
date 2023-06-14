using DesignPatterns.Bridge3;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Select the Message Type 1. For long message or 2. For short message");
        int MessageType = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the message that you want");
        string Message = Console.ReadLine();

        if (MessageType == 1)
        {
            AbstractMessage longMessage = new LongMessage(new SmsMessageSender());
            longMessage.SendMessage(Message);
        }
        else
        {
            AbstractMessage shortMessage = new ShortMessage(new EmailMessageSender());
            shortMessage.SendMessage(Message);
        }
    }
}