namespace BridgeConsole.Database;

public abstract class AbstractDatabase
{
    protected readonly IDatabaseBridge DatabaseBridge;
    public AbstractDatabase(IDatabaseBridge databaseBridge)
    {
        this.DatabaseBridge = databaseBridge;
    }
    public abstract void Save(int id, string name);
    public abstract void Query(string query);
}