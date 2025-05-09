namespace CommandConsole;

public class RemoteInvoker
{
    private ICommand _command;

    public RemoteInvoker(ICommand command)
    {
        _command = command;
    }

    // Allow the ability to swap commands at runtime
    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void PressButton()
    {
        _command.Execute();
    }
}