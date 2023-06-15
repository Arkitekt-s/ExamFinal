namespace ExamFinal;

public class Ufo:PersonClass
{
    public string Planet { get; set; }
    // constructor
    //This is achieved using the base keyword followed by the appropriate arguments to pass to the base class constructor. 
    public Ufo(string name, int age, string planet) : base(name, age)
    {
        Planet = planet;
    }
    public override string GetInfo()
    {
        return $"This Ufo name is {Name} and age is {Age} and planet is {Planet}";
    }
    
    
    
}