namespace BridgeConsole.Database;

public class DatabaseApp
{
    public static void Run()
    {
        IDatabaseBridge database = new MySqlDatabase();
        AbstractDatabase orderDataAccess = new OrderDataAccess(database);
        
        orderDataAccess.Save(1, "Order 1");
        orderDataAccess.Query("SELECT * FROM orders");
        
        database = new OracleDatabase();
        
        orderDataAccess = new OrderDataAccess(database);
        orderDataAccess.Save(2, "Order 2");
    }
}