namespace BridgeConsole.Database;

public class OrderDataAccess : AbstractDatabase
{
    public OrderDataAccess(IDatabaseBridge databaseBridge) : base(databaseBridge)
    {
    }

    public override void Save(int id, string name)
    {
        DatabaseBridge.Connect();
        Thread.Sleep(2000);
        DatabaseBridge.Execute($"INSERT INTO orders (id, name) VALUES ({id}, {name})");
        Thread.Sleep(2000);
        DatabaseBridge.Disconnect();
        Thread.Sleep(2000);
    }

    public override void Query(string query)
    {
        DatabaseBridge.Connect();
        Thread.Sleep(2000);
        DatabaseBridge.Execute(query);
        Thread.Sleep(2000);
        DatabaseBridge.Disconnect();
        Thread.Sleep(2000);
    }
}