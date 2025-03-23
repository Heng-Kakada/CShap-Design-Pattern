
namespace Adapter;

public class Worker : Person
{
    public double Salary { get; set; }
    public string WorkPlace { get; set; }
    public override string Type()
    {
        return "Worker";
    }
    public override string GetInfo()
    {
        return string.Format("{0}, Salary={1:C2}, Work Place={2}", base.GetInfo(), Salary, WorkPlace);
    }
    public Worker(string name, string gender, int age, double salary, string workplace)
        : base(name, gender, age)
    {
        this.Salary = salary;
        this.WorkPlace = workplace;
    }
    public Worker() : this("", "", 0, 0.0, "")
    {
    }
}
