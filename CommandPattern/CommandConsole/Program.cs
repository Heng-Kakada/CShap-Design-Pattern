namespace CommandConsole;

class Program
{
    static void Main(string[] args)
    {
        LightReceiver light = new LightReceiver();
        ICommand offCommand = new TurnOffCommand(light);
        ICommand onCommand = new TurnOnCommand(light);
        
        RemoteInvoker invoker = new RemoteInvoker(onCommand);
        invoker.PressButton();
        
        invoker.SetCommand(offCommand);
        invoker.PressButton();
        
    }
}