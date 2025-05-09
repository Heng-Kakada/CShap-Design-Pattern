namespace DecoratorExample.mix.sub;

public class CoffeeMixing : DrinkMixing
{
    public CoffeeMixing(AbstractDrink comp, string name, double weight): base(comp)
    {
        m_name = name;
        if (m_name == null || string.IsNullOrEmpty(m_name.Trim()))
        {
            m_name = "Unknown Coffee";
        }
        m_weight = weight;
    }

    public override object GetDescription(double weight)
    {
        double per = 0.0;
        if (weight != 0)
        {
            per = m_weight / weight;
        }
        string temp = base.GetDescription(weight).ToString().Trim();
        if (!temp.Equals(""))
        {
            temp += Environment.NewLine;
        }
        return string.Format("{0}Coffee({1}, {2:N2} Gs, {3:P2})", temp, m_name, m_weight, per);
    }

    public override object Update(Type type, string name, double weight)
    {
        if(this.GetType() != type)
        {
            return m_comp.Update(type, name, weight);
        }

        m_name = name;
        m_weight = weight == default ? m_weight : weight;
        return this;
    }
}
