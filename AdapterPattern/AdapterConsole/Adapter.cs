namespace AdapterConsole;

public class Adapter : ITarget
{
    public Adaptee Adaptee;
    
    public Adapter(Adaptee adaptee) => Adaptee = adaptee;
    
    public void Request()
    {
        Adaptee.SpecificRequest();
    }
}