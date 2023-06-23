using System.ComponentModel.DataAnnotations;

namespace ExamFinal;

public class Typesystem
{
    //value type can not be null but refrance type can be null
    //static type cheking and its not dynamic its not week type
    //strongly type means you can not change the type of variable
    //type conversion is not allowed in c# but in js we can change 
    //value type is a struct
    int a = 10;
    int b = 200;
    float c = 10.5f;

    //Enums are useful when you have a limited and well-defined set of options or when you want to improve code readability and maintainability by providing meaningful names for the possible values.
    enum Days
    {
        Sat,
        Sun,
        Mon,
        Tue,
        Wed,
        Thu,
        Fri
    };

    //enum is a value type
    bool d = true;
    
    
    
    


    //refrance type
    public void ExampleMethod()
    {
        RefrenceType First1 = new RefrenceType(10);
        RefrenceType Second2 = First1;
        Second2.x = 20;
        Console.WriteLine("X NUMBER in class refrence IS "+ First1.x);
        //value type can not be change 
        b=a;
        Console.WriteLine("A NUMBER IS "+ a);
        
    }
    public void ExampleStruct()
    {
        StructValue First1 = new StructValue(10);
        StructValue Second2 = First1;
        Second2.x = 20;
        Console.WriteLine("X NUMBER in struct value is "+ First1.x);
        //value type can not be change 
        b=a;
        Console.WriteLine("A NUMBER IS "+ a);
        
    }
    //add a and b
    public void Add()
    {
        Console.WriteLine("c = "+ (a+b));
    }
}

