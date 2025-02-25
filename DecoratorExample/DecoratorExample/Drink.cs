

namespace DecoratorExample;

public class Drink : AbstractDrink
{
    protected string m_name = "Unknown Drink";
    public Drink()
    {
    }
    public Drink(string name)
    {
        if (name == null)
        {
            return;
        }
        name = name.Trim();
        if (name.Equals(""))
        {
            return;
        }
        m_name = name;
    }
    public override object GetDescription(double weight)
    {
        return string.Format("{0}: {1:N2} Gs", m_name, weight);
    }

    public override object Update(Type type, string name, double weight = default)
    {
        if (this.GetType() == type)
        {
            m_name = name == string.Empty ? m_name : name.Trim();
        }
        return this;
    }

    public override double TotalWeight
    {
        get
        {
            return 0.0;
        }
    }
}
