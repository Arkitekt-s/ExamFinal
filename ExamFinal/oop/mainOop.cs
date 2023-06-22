namespace ExamFinal;

public class mainOop
{
    public static void mainOop2()
    {
        //oopin c#
        //class the refrance of this object pass a round in memory
        PersonClass person = new PersonClass("soheil", 20);
        PersonClass person2 = new PersonClass("lisha", 30);
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
        
        //inheritance
        Ufo ufo1 = new Ufo("z489UFO", 40, "Mars");
        Console.WriteLine(ufo1.GetInfo());
        Ufo.Walking();
        Console.WriteLine(Ufo.NumberofPeople);
        
        ufo1.DepartmentApducted();
        PersonClass ali4 = ufo1[4];
        Console.WriteLine(ali4.GetInfo());
        




        //struct the copy of this object pass a round in memory
        PersonStructs person3 = new PersonStructs("soheilstruct", 80);
        Console.WriteLine(person3.ToString());
        
        
        PersonRecord person4 = new PersonRecord("soheilrecord", 89);
        Console.WriteLine(person4.ToString());
        
        //var vs dynamic
        //var is static type and dynamic is dynamic type
        //var is compile time and dynamic is runtime
        var myVar = 10;
        Console.WriteLine(myVar);
        dynamic myDynamic = "soheil";
        Console.WriteLine(myDynamic);
    }
}