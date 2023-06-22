using System.Net.Sockets;
using System.Runtime.CompilerServices;
using ExamFinal;
using ExamFinal.Abstract;
using ExamFinal.ArrysAndCollections;
using ExamFinal.MethodLevelStructures;
using Array = System.Array;

class main
{
    static void Main(string[] args)
    {
        mainLinq.mainLinq1();

        mainOop.mainOop2();
        mainAbstract.Abstractmain1();
        mainArrys.mainArry1();
        mainImprative.mainImprative1();
        mainMethodLevelStructures.mainMethodLevelStructures1();
        
        //type conversion




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
        
        
        //Array single dimension
        int [] arr1= new int[5];
        arr1[0] = 10;
        arr1[1] = 20;
        arr1[2] = 30;
        // Print the elements of arr1
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.WriteLine(arr1[i]);
        }

        Console.WriteLine("Array Length: " + arr1.Length);
        //sort the array
        Console.WriteLine("Array Max: " + arr1.Max());
        Console.WriteLine("Array Min: " + arr1.Min());
        Console.WriteLine("Array Sum: " + arr1.Sum());
        Console.WriteLine("Array Average: " + arr1.Average());
        //sorting 
        
            
        
        
        
        int [] arr2 = new int[5] {10,20,30,40,50};
        
        //linear array 
        int [] arr3 = new int [] {20,30,10,40,50};
        Console.WriteLine(arr3[0]);
        //sort this array
        Array.Sort(arr3);
        foreach (int num in arr3)
        {
            Console.WriteLine(num +"Array3 ");
        }
        
        //Multidimensional array define size
        int [,] arr4 = {{10,20},{30,40}};
        Console.WriteLine(arr4[0,0]);
        
         
        //not need to define size for jagged array
        
         //jagged array with the size of the 3 first dimension and the second dimension is not defined
         int[][] jaggedArray = new int[4][];
         jaggedArray[0] = new int[2] { 1, 2 };
         jaggedArray[1] = new int[3] { 3, 4, 5 };
         jaggedArray[2] = new int[4] { 6, 7, 8, 9 };
         //empty array
         jaggedArray[3] = new int [] {};
        // print the array in forloop
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.WriteLine(jaggedArray[i][j]);
            }
        }
        
        //indexer range and spanse
        int [] arr7 = new int [] {100,200,300,400,500};
        Index x= ^1;
        //count from the end of the array we use ^
        Console.WriteLine(x);
        Console.WriteLine(x.IsFromEnd);
        Console.WriteLine(arr7[x]);
        
        var range =0..3;
        
        var portion = arr7[range];
        //print a s a list
        portion.ToList().ForEach(s=>Console.WriteLine(s));
        //span is change the orginal array lightweight and efficient
        var span = new Span<int>(arr7,0,3);
        foreach (var num in span)
        {
            Console.WriteLine("span: "+num);
        }
        
        
        

           
            
            





























    }
}





