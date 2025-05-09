namespace BridgeConsole.Database;

public class OracleDatabase : IDatabaseBridge
{
    public void Connect()
    {
        Console.WriteLine("Connecting to Oracle");
    }

    public void Disconnect()
    {
        Console.WriteLine("Disconnecting from Oracle");
    }

    public void Execute(string query)
    {
        Console.WriteLine($"Executing query: {query}");
    }
}