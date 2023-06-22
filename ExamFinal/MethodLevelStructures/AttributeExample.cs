using System.Runtime.InteropServices;

namespace ExamFinal.MethodLevelStructures;

public class AttributeExample 

{
    //WITH ATRIBUTE TARGET WE CAN MINIMIZE THE ACCESS OF THE ATTRIBUTE TO THE CALSS OR METHOD OR PROPERTY
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    class sampleAttribute : Attribute
    {
        //atribute is a class that inherits from Attribute class 
        public int Id { get; set; }
        public string Name { get; set; }
    }

    
    [sampleAttribute(Id = 1, Name = "MyClassSoheil")]
    
    class MyclassAtribute
    {
        public int MyProperty { get; set; }
        
        
        public void MyMethod()
        {
            Console.WriteLine("My Method");
        }
    }
}
