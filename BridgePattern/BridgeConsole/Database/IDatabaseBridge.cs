namespace BridgeConsole.Database;

public interface IDatabaseBridge
{
    public void Connect();
    public void Disconnect();
    public void Execute(string query);
}