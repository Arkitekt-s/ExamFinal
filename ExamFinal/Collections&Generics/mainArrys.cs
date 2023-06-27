using System.Runtime.InteropServices.JavaScript;

namespace ExamFinal.ArrysAndCollections;
using Array = System.Array;

public class mainArrys
{
    public static void mainArry1()
    {
       
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\n" + new string('*', 50) + " Collections & Generics" + new string('*', 50));
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\n" + new string('*', 10) + "Arrays" + new string('*', 10));
        Console.ResetColor();
        //int array
        int [] intArray = new int [] {10000,20000,30000,40000,50000};
        //string array
        string [] stringArray = new string [] {"leo","jack","sara"};
        //double array
        double [] doubleArray = new double [] {10.1,20.2,30.3,40.4,50.5};
        //object array
        object [] objectArray = new object [] {10,20,30,40,50,"soheil","sara","jack",10.1,20.2,30.3,40.4,50.5};
        displayElementO(objectArray);
        //if i need to accept my double i need complitly different argument for double 
        displayElementS(stringArray);
        displayElementD(doubleArray);
        
        static void displayElementO(object[]array)
        {
            foreach (object item in array)
            {
                Console.WriteLine($"object array: {item}");
            }
        }
        static void displayElementD(double[]array)
        {
            foreach (double item in array)
            {
                Console.WriteLine($"double array: {item}");
            }
             
        }
        static void displayElementS(string[]array)
        {
            foreach (string item in array)
            {
                Console.WriteLine($"string array: {item}");
            }
             
        }
        //Array single dimension
        //declear the size[5] and the type of the array is int
        int [] arr1= new int[5];
        arr1[0] = 10;
        arr1[1] = 20;
        arr1[2] = 30;
        arr1[3] = 40;
        arr1[4] = 50;
        // Print the elements of arr1 in the list
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.WriteLine("arr1: "+arr1[i]);
        }
        //var is a implicit type
        var arr5 = new[] { "hi", "hello", "bye" };

        Console.WriteLine("Array Length: " + arr1.Length);
        //sort the array
        Console.WriteLine("Array Max: " + arr1.Max());
        Console.WriteLine("Array Min: " + arr1.Min());
        Console.WriteLine("Array Sum: " + arr1.Sum());
        Console.WriteLine("Array Average: " + arr1.Average());
        //sorting 
        
        int [] arr2 = new int[5] {10,20,30,40,50};
        
        //linear array 
        int [] arr3 = new int [] {2000,3,100,400,5};
        Console.WriteLine(arr3[0]);
        //sort this array
        System.Array.Sort(arr3);
        Console.WriteLine("Array.sort: " + string.Join(", ", arr3));
        //reverse the array
        System.Array.Reverse(arr3);
        Console.WriteLine("Array.Reverse: " + string.Join(", ", arr3));


        //Multidimensional array define size
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\n" + new string('*', 10) + "Multidimensional Array" + new string('*', 10));
        Console.ResetColor();
        
        int [,] MultidimensionalArray = {{10,20},{30,40}};
        Console.WriteLine($"first row and first column grid-like structure: {MultidimensionalArray[0,0]}");
        
         
        //not need to define size for jagged array
        
         //jagged array with the size of the 3 first dimension and the second dimension is not defined
         Console.ForegroundColor = ConsoleColor.DarkYellow;
         Console.WriteLine("\n" + new string('*', 10) + "JaggedArray" + new string('*', 10));
         Console.ResetColor();
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
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\n" + new string('*', 10) + "Range/Index" + new string('*', 10));
        Console.ResetColor();
        //indexer range and spanse
        int [] IndexArry = new int [] {100,200,300,400,500};
        Index x= ^1;
        //count from the end of the array we use ^
        Console.WriteLine($"count from the end of the array : {IndexArry[x]}");
        Console.WriteLine(x.IsFromEnd);
        
        
        var range =0..3;
        
        var portion = IndexArry[range];
        //print a s a list
        portion.ToList().ForEach(s=>Console.WriteLine("range: "+s));
        //span is change the orginal array lightweight and efficient
        
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\n" + new string('*', 10) + "Span" + new string('*', 10));
        Console.ResetColor();

        Span<int> span = IndexArry[0..5];
        span[0]=1000;
        span[1]=2000;
        foreach (var num in span)
        {
            Console.WriteLine("span: "+num);
        }
        
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\n" + new string('*', 10) + "Object Indexers" + new string('*', 10));
        Console.ResetColor();
        //indexers
        var tempRecord = new TempRecord();
        tempRecord[3] = 58.3f;
        tempRecord[5] = 60.1f;
        Console.WriteLine($"Indexer: {tempRecord[3]}");
        Console.WriteLine($"Indexer: {tempRecord[5]}"); 
        Console.WriteLine($"Length: {tempRecord.Length}");
        for (int i = 0; i < tempRecord.Length; i++)
        {
            Console.WriteLine($"Element #{i} = {tempRecord[i]}");
        }
        
        
         Console.ForegroundColor = ConsoleColor.DarkYellow;
         Console.WriteLine("\n" + new string('*', 10) + "Generic" + new string('*', 10));
         Console.ResetColor();
         //generic method so accept all type of array
            static void displayElementT<T>(T[]array)
            {
                foreach (T item in array)
                {
                    Console.WriteLine(item+" ");
                }
                
            }
            displayElementT(stringArray);
            displayElementT(objectArray);
            
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n" + new string('*', 10) + "Covariance &invariance" + new string('*', 10));
            Console.ResetColor();
            
            Parent parent1 = new Parent("soheil");
            Parent parent2 = new MaleChild("jack","usa",32);
            MaleChild malechild= new MaleChild("alex","usa",12);
            FemailChild femailchild = new FemailChild("anja","uk",13);
            //can not creat parents object from child class
            //Child c1 = new Parent("leo"); invalid
            
            parent1.ParentMethod();
            parent2.ParentMethod();
            //can not access to child method from parent class
            //parent1.ChildMethod();
            malechild.ParentMethod();
            malechild.MaleChildMethod();
            
            parent1= malechild; //covariant where child is a parent
            //This line demonstrates covariance, where you assign an instance of MaleChild (cm) to a variable of type Parent (p).
            //Covariance is allowed because MaleChild is derived from Parent, and assigning a derived type object to a
            //base type reference is permissible.
            
           //malechild=parent; //contravariant where parent is a child its not allowed
            MaleChild[] objectMaleChildrenArray={new MaleChild("jack","usa",12),new MaleChild("alex","usa",22)};
            IEnumerable<Parent> objectParentArray = objectMaleChildrenArray;
            
            Parent[] objectParentArray2={new Parent("soheil"),new Parent("ANJA")};
            //IEnumerable<MaleChild> objectMaleChildrenArray2 = objectParentArray2;
            
    }
}