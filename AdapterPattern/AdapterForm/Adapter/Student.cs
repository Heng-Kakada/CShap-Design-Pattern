namespace Adapter;

public class Student : Person
{
    public double Score { get; set; }
    public override string Type()
    {
        return "Student";
    }
    public override string GetInfo()
    {
        return string.Format("{0}, Score={1:N2}", base.GetInfo(), Score);
    }
    public Student(string name, string gender, int age, double score)
        : base(name, gender, age)
    {
        this.Score = score;
    }
    public Student() : this("", "", 0, 0.0)
    {
    }
}