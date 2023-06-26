namespace ExamFinal;

public class mainOop
{
    public static void mainOop2()
    {
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + new string('*', 10) + "Classes and Properties" + new string('*', 10));
        Console.ResetColor();
        //oopin c#
        //class the refrance of this object pass a round in memory
        PersonClass person = new PersonClass("soheil", 30);
        PersonClass person2 = new PersonClass("Anja", 30);
        Console.WriteLine(person.GetInfo() );
        Console.WriteLine(person2.GetInfo() );
        PersonClass.Walking();
        Console.WriteLine(PersonClass.NumberofPeople);
        //object initializer we dont need constructorif i dont have any constructor
        PersonClass person7 = new PersonClass
        {
            Name = "emty name soheil",
        };
        Console.WriteLine(person7.Name);
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + new string('*', 10) + "Struct(ValueType)" + new string('*', 10));
        Console.ResetColor();
        //struct the copy of this object pass a round in memory
        PersonStructs person3 = new PersonStructs("soheilstruct", 80);
        Console.WriteLine(person3.ToString());
        
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + new string('*', 10) + "Record(Immutable data)" + new string('*', 10));
        Console.ResetColor();
        
        PersonRecord person4 = new PersonRecord("soheilrecord", 89);
        Console.WriteLine($"Build in tostring on record: {person4}");
        
        
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + new string('*', 10) + "Inheritance" + new string('*', 10));
        Console.ResetColor();
        //inheritance
        Ufo ufo1 = new Ufo("z489UFO", 40, "Mars");
        Console.WriteLine(ufo1.GetInfo());
        Ufo.Walking();
        Console.WriteLine(Ufo.NumberofPeople);
        
        ufo1.DepartmentApducted();
        PersonClass ali4 = ufo1[4];
        Console.WriteLine(ali4.GetInfo());
        
        
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
        var myVar = 10;
        Console.WriteLine("var is static type and early binding : value=" + myVar);
        dynamic myDynamic = "soheil";
        Console.WriteLine("dynamic is dynamic type and late binding : value=" + myDynamic);
    }
}