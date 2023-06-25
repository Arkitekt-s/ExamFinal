using System.Diagnostics.CodeAnalysis;

namespace ExamFinal;

public class mainImprative
{
    public static void mainImprative1()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\n" + new string('*', 10) + "Type System" + new string('*', 10));
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\n" + new string('*', 10) + "Reference Type" + new string('*', 10));
        Console.ResetColor();
        //refrance tyoe 
        
        MyClass classobj1= new MyClass();
        classobj1.value = 10;
        MyClass classobj2= classobj1;//copy the refrance
        classobj2.value = 20;
        Console.WriteLine($"classobj1.value coppying the reference: {classobj1.value}");
        Console.WriteLine($"classobj2.value coppying the reference: {classobj2.value}");
        
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\n" + new string('*', 10) + "Value Type" + new string('*', 10));
        Console.ResetColor();
        //value type
        MyStruct structobj1= new MyStruct(10);
        MyStruct structobj2= structobj1;//copy the value
        structobj2.x = 20;
        Console.WriteLine($"structobj1.x coppying the value: {structobj1.x}");
        Console.WriteLine($"structobj2.x coppying the value: {structobj2.x}");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\n" + new string('*', 10) + "Overloads" + new string('*', 10));
        Console.ResetColor();
        Vector v1 = new Vector(2, 3);
        Vector v2 = new Vector(4, 5);
        Vector sum = v1 + v2;
        Console.WriteLine($"Sum: {sum.X},{sum.Y}");
        //overload
        Overload l1 = new Overload(300,12.1212);
        Overload l2 = new Overload(10,13.131313);
        Overload l4 = new Overload(10, 10);
        Overload l3 = l1 - l2;
        //show to decimal
        Console.WriteLine($"{l1.inch:F2} inch {l1.inch,20}");
        
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\n" + new string('*', 10) + "Null handling" + new string('*', 10));
        Console.ResetColor();
        //assine null to the person
        Person ?p1 = null;
        var p2= new Person();
        var p3= new Person("tim",22,2000.500548m);
        
        p1?.GetPossibleName();
        p2.GetPossibleName();
        p3.GetPossibleName();
        
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\n" + new string('*', 10) + "String interpolation" + new string('*', 10));
        Console.ResetColor();
        
        //@The newline character is included directly within the string
        //@ direct copy the string and dont need to escape
        //print p3 with string interpolation
        Console.WriteLine($"Name: {p3.Name} Age: {p3.Age} Salary: {p3.Salary:F1}");
        var myString = @"\\this is my string$$";
        Console.WriteLine(myString);
        var myString2 = "\\this is my string$$";
        Console.WriteLine(myString2);
        //row string which is used for html and xml and json and sql this is help to write string
        var Xml="""
            <?xml version=""1.0"" encoding=""utf-8""?>
            <title>Programming C#</title>
            <author>Soheil</author>
            <price>10</price>
            """;
        Console.WriteLine(Xml);
        Console.WriteLine(l1.ConvertToCm());
        Console.WriteLine(l2.ConvertToCm());
        Console.WriteLine(l3.ConvertToCm());
        
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\n" + new string('*', 10) + "Pattern matching" + new string('*', 10));
        Console.ResetColor();
        
        Overload.TypePattern("soheil");
        Overload.SwitchPattern(10.1);
        Overload.PropertyPattern(l4);

    }
}