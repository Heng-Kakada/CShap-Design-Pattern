namespace PrototypeConsole;

public class Prototype : IPrototype
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public Prototype(int id, string name)
    {
        Id = id;
        Name = name;
    }
    
    public object Clone()
    {
        return (Prototype)MemberwiseClone();
    }
}