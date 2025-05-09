namespace Adapter;

public class Person
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Age { get; set; }
    public virtual string Type()
    {
        return "Person";
    }
    public virtual string GetInfo()
    {
        return string.Format("Name={0}, Gender={1}, Age={2}", Name, Gender, Age);
    }
    public Person(string name, string gender, int age)
    {
        this.Name = name;
        this.Gender = gender;
        this.Age = age.ToString();
    }
    public Person() : this("", "", 0)
    {
    }
}
