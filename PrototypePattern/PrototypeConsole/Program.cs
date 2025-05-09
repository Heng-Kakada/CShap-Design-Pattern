namespace PrototypeConsole;

class Program
{
    static void Main(string[] args)
    {
        PrototypeManager manager = new PrototypeManager();
        Prototype p1, p2;

        p1 = (Prototype)manager.GetPrototype("first").Clone();

        Console.WriteLine($"{p1.Id} - {p1.Name}");
        
        p1.Name = "Prototype 1 - Modified";
        Console.WriteLine($"{p1.Id} - {p1.Name}");
        Console.WriteLine($"Original {manager.GetPrototype("first").Name}");

    }
}