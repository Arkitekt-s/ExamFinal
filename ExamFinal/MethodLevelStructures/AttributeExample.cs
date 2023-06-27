using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ExamFinal.MethodLevelStructures;

public class AttributeExample

{
    //WITH ATRIBUTE TARGET WE CAN MINIMIZE THE ACCESS OF THE ATTRIBUTE TO THE CALSS OR METHOD OR PROPERTY
    //annotaion which give extra meaning to the code
    //run time and compile time behavior controlle
    //AtributeUsage can minimize the access of the attribute to the class or method or property
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method)]
    public class SampleAttribute : Attribute
    {
        //atribute is a class that inherits from Attribute class '
        [Required] public int Id { get; set; }

        [Range(18, 99)] public int Age { get; set; }
        [Required] public string Name { get; set; }
        [EmailAddress] public string Email { get; set; }
        
        //counstructer
        public SampleAttribute(int id, int age, string name, string email)
        {
            Id = id;
            Age = age;
            Name = name;
            Email = email;
        }

    }

    


    [SampleAttribute(1,18,  "MyClassSoheil",  "2213@11.com")]
    public class TestClass
    {
        public int MyProperty { get; set; }
        
        [SampleAttribute( 2,   28, "MyMethodSoheil", "2123@11.com")]
        public void MyMethod()
        {
            Console.WriteLine("My Method");
        }
    }
    public class NotAtrribute
    {
    }
}
