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
    
    
    
    

    
}

