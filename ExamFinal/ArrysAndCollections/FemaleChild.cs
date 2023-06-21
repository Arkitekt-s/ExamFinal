namespace ExamFinal.ArrysAndCollections;

public class FemailChild :Parent
{
    public string country { get; set; }
    public int age { get; set; }
    public FemailChild(string name, string country, int age) : base(name)
    {
        this.country = country;
        this.age = age;
    }
    
    public override string ToString()
    {
        return $"Name: {Name}, Country: {country}, Age: {age}";
    }
    public void FemaleChildMethod()
    {
        Console.WriteLine("FemaleChild Method");
    }
}