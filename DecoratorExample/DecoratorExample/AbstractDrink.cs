namespace DecoratorExample;

public abstract class AbstractDrink
{
    public abstract object GetDescription(double weight);
    public abstract double TotalWeight { get; }
    public string? Description
    {
        get
        {
            return GetDescription(TotalWeight).ToString();
        }
    }
    public abstract object Update(Type type, string name, double weight = default);
}
