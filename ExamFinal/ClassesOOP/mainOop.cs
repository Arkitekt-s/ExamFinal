namespace ExamFinal;

public class mainOop
{
    public static void mainOop2()
    {
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + new string('*', 50) + "Classes and Properties" + new string('*', 50));
        Console.ResetColor();
        //oopin c#
        //class the refrance of this object pass a round in memory
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + new string('*', 10) + "constructor with parameters" + new string('*', 10));
        Console.ResetColor();
        PersonClass person = new PersonClass("soheil", 30);
        person.DisplayInfo();
        PersonClass person2 = new PersonClass("Anja", 30);
        person2.DisplayInfo();
        PersonClass.Walking();
        Console.WriteLine($"Number of people is {PersonClass.NumberofPeople}");
        //object initializer we dont need constructorif i dont have any constructor
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + new string('*', 10) + "Empty Constructor/Default value" + new string('*', 10));
        Console.ResetColor();
        
        
        PersonClass person7 = new PersonClass();
        person7.DisplayInfo();
        Console.WriteLine($"Number of people is {PersonClass.NumberofPeople}");
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + new string('*', 10) + "Constructor Chaining" + new string('*', 10));
        Console.ResetColor();
        
        
        PersonClass person8 = new PersonClass("Alice");
        person8.DisplayInfo();
        Console.WriteLine($"Number of people is {PersonClass.NumberofPeople}");
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + new string('*', 10) + "Struct(ValueType)" + new string('*', 10));
        Console.ResetColor();
        //struct the copy of this object pass a round in memory
        PersonStructs person3 = new PersonStructs("soheilstruct", 80);
        Console.WriteLine(person3.ToString());
        
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + new string('*', 10) + "Record(Immutable data)-readonly" + new string('*', 10));
        Console.ResetColor();
        
        PersonRecord person4 = new PersonRecord("soheilrecord", 89);
        Console.WriteLine($"Build in tostring on record: {person4}");
        
        
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + new string('*', 10) + "Inheritance" + new string('*', 10));
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + new string('*', 10) + "Constructor chaining-base_keyword" + new string('*', 10));
        Console.ResetColor();
        
        //inheritance
        Ufo ufo1 = new Ufo("z489UFO", 40, "Mars");
        Console.WriteLine(ufo1.GetInfo());
        Ufo.Walking();
        Console.WriteLine(Ufo.NumberofPeople);
        
        ufo1.DepartmentApducted();
        PersonClass ali4 = ufo1[4];
        Console.WriteLine(ali4.Name);
        
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + new string('*', 10) + "Polymorphism" + new string('*', 10));
        Console.WriteLine("virtual(person) and override(ufo) method");
        Console.ResetColor();
        
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + new string('*', 10) + "Static vs Dynamic" + new string('*', 10));
        Console.ResetColor();
        //var vs dynamic
        //var is static type and dynamic is dynamic type
        //var is compile time and dynamic is runtime
        var myVar = "soheil";
        int length = myVar.Length;
        Console.WriteLine("var is static type and early binding compile time error: myVar lenght=" + length);

        dynamic myDynamic = "soheil";
        //string length2 = myDynamic.Length;
        Console.WriteLine("dynamic is dynamic type and late binding run time error: myDynamic=" + myDynamic);
    }
}