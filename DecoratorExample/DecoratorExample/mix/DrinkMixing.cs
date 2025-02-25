namespace DecoratorExample.mix;

public abstract class DrinkMixing : AbstractDrink
{
    protected AbstractDrink m_comp;
    protected string m_name = "";
    protected double m_weight = 0.0;
    public DrinkMixing(AbstractDrink comp)
    {
        if (comp == null)
        {
            throw new Exception("Drink provided is nothing.");
        }
        m_comp = comp;
    }
    public override object GetDescription(double weight)
    {
        if (m_comp == null)
        {
            return Convert.ToDouble("");
        }
        return m_comp.GetDescription(weight);
    }

    public override double TotalWeight
    {
        get
        {
            double temp = 0.0;
            if (m_comp != null)
            {
                temp = m_comp.TotalWeight;
            }
            return temp + m_weight;
        }
    }
}
