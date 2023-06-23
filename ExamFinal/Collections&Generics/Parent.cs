namespace ExamFinal.ArrysAndCollections;

public class Parent
{
    public string Name { get; set; }
    
    
    public Parent(string name)
    {
        Name = name;
    }
    
    public override string ToString()
    {
        return $"Name: {Name}";
    }
    
    public void ParentMethod()
    {
        Console.WriteLine("Parent Method");
    }
}