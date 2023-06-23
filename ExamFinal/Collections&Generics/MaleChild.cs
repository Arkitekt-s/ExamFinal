namespace ExamFinal.ArrysAndCollections;

public class MaleChild: Parent
{
    public string country { get; set; }
    public int age { get; set; }
    
    public MaleChild(string name, string country, int age) : base(name)
    {
        this.country = country;
        this.age = age;
    }
    
    public override string ToString()
    {
        return $"Name: {Name}, Country: {country}, Age: {age}";
    }
    public void MaleChildMethod()
    {
        Console.WriteLine("MaleChild Method");
    }
    
}