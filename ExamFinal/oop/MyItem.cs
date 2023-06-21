namespace ExamFinal;

public class MyItem
{
    public string Name { get; set; }
    
    

    public MyItem(string name)
    {
        Name = name;
        
    }

    public override string ToString()
    {
        return $"Name: {Name}";
    }
}