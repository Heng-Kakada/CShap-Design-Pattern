namespace BridgeConsole.Database;

public class MySqlDatabase : IDatabaseBridge
{
    public void Connect()
    {
        Console.WriteLine("Connecting to MySQL");
    }

    public void Disconnect()
    {
        Console.WriteLine("Disconnecting from MySQL");
    }

    public void Execute(string query)
    {
        Console.WriteLine($"Executing query: {query}");
    }
}