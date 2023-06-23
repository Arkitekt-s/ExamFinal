namespace ExamFinal;

public class mainImprative
{
    public static void mainImprative1()
    {
        //refrance tyoe 
        Typesystem typesystem = new Typesystem();
        typesystem.ExampleMethod();
        //value type
        typesystem.ExampleStruct();
        //overload
        Overload l1 = new Overload(300,12.1212);
        Overload l2 = new Overload(10,13.131313);
        Overload l4 = new Overload(10, 10);
        Overload l3 = l1 - l2;
        //show to decimal
        Console.WriteLine($"{l1.inch:F2} inch {l1.inch,20}");
        //@The newline character is included directly within the string
        //@ direct copy the string and dont need to escape
        var myString = @"\this is my string$$";
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
        Overload.TypePattern("soheil");
        Overload.SwitchPattern(10.1);
        Overload.PropertyPattern(l4);

    }
}