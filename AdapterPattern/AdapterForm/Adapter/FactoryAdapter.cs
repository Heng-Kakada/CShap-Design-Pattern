using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter;
 public class FactoryAdapter : IInfo
{
    private Factory m_factory = null;
    public FactoryAdapter(Factory factory)
    {
        if (factory == null)
        {
            throw new Exception("It requires a factory to be adapted.");
        }
        m_factory = factory;
    }
    public string Text
    {
        get
        {
            return string.Format("Name={0}, Workers={1:N0}, Location={2}",
                m_factory.Name, m_factory.Workers, m_factory.Location);
        }
    }
    public string Type
    {
        get
        {
            return "Factory";
        }
    }
}
