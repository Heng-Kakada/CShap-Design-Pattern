namespace CommandConsole;

public class TurnOnCommand: ICommand
{
    private LightReceiver _light;

    public TurnOnCommand(LightReceiver light)
    {
        _light = light;
    }
    public void Execute()
    {
        _light.ActionOn();
    }
}