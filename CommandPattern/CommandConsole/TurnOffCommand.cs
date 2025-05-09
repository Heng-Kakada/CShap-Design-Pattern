namespace CommandConsole;

public class TurnOffCommand : ICommand
{
    private LightReceiver _light;
        public TurnOffCommand(LightReceiver light)
        {
            _light = light;
        }
    public void Execute()
    {
        _light.ActionOff();
    }
}