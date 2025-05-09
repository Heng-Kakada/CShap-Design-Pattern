namespace PrototypeConsole;

public class PrototypeManager: IPrototype
{
    public Dictionary<string, Prototype> Prototypes = new Dictionary<string, Prototype>()
    {
        { "first", new Prototype(1, "Prototype 1") },
        { "second", new Prototype(2, "Prototype 2") }
    };
    
    public Prototype GetPrototype(string key)
    {
        return Prototypes[key];
    }
    
    public object Clone()
    {
        return (PrototypeManager)MemberwiseClone();
    }
}