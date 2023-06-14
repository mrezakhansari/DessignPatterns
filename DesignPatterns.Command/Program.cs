
using DesignPatterns.Command;

public class Program
{
    private static void Main(string[] args)
    {
        SimpleRemoteControl remoteControl = new SimpleRemoteControl();
        Light light = new Light();
        Stereo stereo = new Stereo();

        remoteControl.SetCommand(new LightOnCommand(light));
        remoteControl.ButtonWasPressed();

        remoteControl.SetCommand(new StereoOnWithCDCommand(stereo));
        remoteControl.ButtonWasPressed();
    }
}