using System.Net.Sockets;
using System.Runtime.CompilerServices;
using ExamFinal;
using ExamFinal.ArrysAndCollections;
using Array = System.Array;

class main
{
    static void Main(string[] args)
    {

        var myBooks = new List<BookLinq>();
        {
            myBooks.Add(new BookLinq { Title = "The AHobbit", Author = "J.R.R. Tolkien", Price = 10 });
            myBooks.Add(new BookLinq { Title = "The BFellowship of the Ring", Author = "J.R.R. Tolkien", Price = 20 });
            myBooks.Add(new BookLinq { Title = "The CTwo Towers", Author = "J", Price = 30 });
            myBooks.Add(new BookLinq { Title = "The DReturn of the King", Author = "R Tolkien", Price = 40 });
        }
         var myBooks2 = new List<BookLinq>();
         {
             myBooks2.Add(new BookLinq { Title = "a", Author = "soheil", Price = 1 });
             myBooks2.Add(new BookLinq { Title = "jbook", Author = "J", Price = 2 });
             myBooks2.Add(new BookLinq { Title = "jboo2", Author = "J", Price = 3 });
             myBooks2.Add(new BookLinq { Title = "d", Author = "merry", Price = 4 });
         }


         //Use the extension method to filter books by author
        var FilteredBooks = myBooks.FilterByAuthor("J");
        foreach (var book in FilteredBooks)
        {
            Console.WriteLine("FilterByAuthorExtension: " + book.Title);
        }

        // LINQ (Language-Integrated Query) 
        //grope by author of to list of mybooks and mybooks2
        var mergedBooks = myBooks.Concat(myBooks2);
        var myNewgroup = mergedBooks.GroupBy(x => x.Author)
            .ToDictionary(x => x.Key, x => x.ToList());
        foreach (var Books in myNewgroup)
        {
            Console.WriteLine("grope by author: " + Books.Key);
            foreach (var book in Books.Value)
            {
                Console.WriteLine(book.Title);
            }
        }
        



        //Where: Filters a sequence of elements specifying a condition
        var myNewBooks1 = myBooks.Where(x => x.Price == 10);
        foreach (var Books1 in myNewBooks1)
        {
            Console.WriteLine("spesific the condition using where: " + Books1.Title);
        }

        //Select: Projects each element of a sequence into a new form
        var myNewBooks2 = myBooks.Select(x => x.Title);
        foreach (var Books2 in myNewBooks2)
        {
            Console.WriteLine("specify what specific data you want to select using select: " + Books2);
        }

        //orderby and sort the collection
        var myNewBooks3 = myBooks.OrderBy(x => x.Title);
        foreach (var Books3 in myNewBooks3)
        {
            Console.WriteLine("sort the collection using orderby: " + Books3.Title);
        }

        //orderby descending and sort the collection
        var myNewBooks4 = myBooks.OrderByDescending(x => x.Price);
        foreach (var Books4 in myNewBooks4)
        {
            Console.WriteLine("sort the collection using orderbydescending: " + Books4.Price);
        }

        //count the collection
        var myNewBooks5 = myBooks.Count(x => x.Price > 10);
        Console.WriteLine("count the collection using count: " + myNewBooks5);
        //first
        var myNewBooks10 = myBooks.First(x => x.Price > 35);
        Console.WriteLine("first the collection using first: " + myNewBooks10);
        //last
        var myNewBooks11 = myBooks.Last(x => x.Price > 35);
        Console.WriteLine("last the collection using last: " + myNewBooks11);
        
        //sum the collection
        var myNewBooks6 = myBooks.Sum(x => x.Price);
        Console.WriteLine("sum the collection using sum: " + myNewBooks6);
        var myNewBooks7 = myBooks.Average(x => x.Price);
        Console.WriteLine("average the collection using average: " + myNewBooks7);
        //max the collection
        var myNewBooks8 = myBooks.Max(x => x.Price);
        Console.WriteLine("max the collection using max: " + myNewBooks8);
        //min the collection
        var myNewBooks9 = myBooks.Min(x => x.Price);
        Console.WriteLine("min the collection using min: " + myNewBooks9);
        



        //use linq sort list and make it easy and fast
        //ThenBy is used to sort the collection by another property
        var myNewBooks = myBooks.Where(x => x.Author == "J.R.R. Tolkien")
            .OrderBy(x => x.Title).
            ThenBy(x => x.Price)
            .Select(x => x.Title);
        foreach (var Book in myNewBooks)
        {
            Console.WriteLine(Book);
        }

        //without using linq

        foreach (var book in myBooks)
        {
            if (book.Author == "J.R.R. Tolkien")
            {
                Console.WriteLine(book.Title);
            }
        }


        //Query Syntax:
        var query = from book in myBooks
            where book.Author == "J.R.R. Tolkien"
            orderby book.Title
            select book.Title;
        foreach (var title in query)
        {
            Console.WriteLine("Query Syntax title: " + title);
        }

        //other Query Syntax:
        var query2 = from book in myBooks
            where book.Price > 10
            orderby book.Title
            select book.Title;
        foreach (var title in query2)
        {
            Console.WriteLine("Query Syntax price: " + title);
        }
        
        
        
        
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
        
        
        //Generics
        
        //tree different type of array
        //int array
        int [] intArray = new int [] {1000,2000,3000,4000,5000};
        //string array
        string [] stringArray = new string [] {"leo","jack","sara"};
        //double array
        double [] doubleArray = new double [] {10.1,20.2,30.3,40.4,50.5};
        //object array
        object [] objectArray = new object [] {10,20,30,40,50,"soheil","sara","jack",10.1,20.2,30.3,40.4,50.5};
        
        displayElementI(intArray);
        //if i need to accept my double i need complitly different argument for double 
        displayElementD(doubleArray);
        
        displayElementS(stringArray);
        
        
        
         static void displayElementI(int[]array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item+" ");
            }
        }
         static void displayElementD(double[]array)
         {
             foreach (double item in array)
             {
                 Console.WriteLine(item+" ");
             }
             
         }
         static void displayElementS(string[]array)
         {
             foreach (string item in array)
             {
                 Console.WriteLine(item+" ");
             }
             
         }
         //generic method so accept all type of array
            static void displayElementT<Thing>(Thing[]array)
            {
                foreach (Thing item in array)
                {
                    Console.WriteLine(item+" ");
                }
                
            }
            displayElementT(stringArray);
            displayElementT(objectArray);
            //array in c sharp is  called covariant 
            string[] s = new string[10];
            object[] o = s;
            o[0]="soheil";
            //this attempt is ok in compiles fine and fail in runntime
            //o[1]=10;
            Console.WriteLine(s[0]);
            
            
            
            Parent parent = new Parent("soheil");
            Parent parent1 = new MaleChild("jack","usa",12);
            MaleChild malechild= new MaleChild("alex","usa",22);
            FemailChild femailchild = new FemailChild("anja","uk",33);
            //can not creat parents object from child class
            //Child c1 = new Parent("leo"); invalid
            
            parent.ParentMethod();
            parent1.ParentMethod();
            //can not access to child method from parent class
            //p1.ChildMethod();
            malechild.ParentMethod();
            malechild.MaleChildMethod();
            
            parent= malechild; //covariant where child is a parent
            //This line demonstrates covariance, where you assign an instance of MaleChild (cm) to a variable of type Parent (p). Covariance is allowed because MaleChild is derived from Parent, and assigning a derived type object to a base type reference is permissible.
            
           //malechild=parent; //contravariant where parent is a child its not allowed
            MaleChild[] objectMaleChildrenArray={new MaleChild("jack","usa",12),new MaleChild("alex","usa",22)};
            //give me complie time error
            //Parent[] objectParentArray = objectMaleChildrenArray;
            //objectParentArray[0] = new FemailChild("anja","uk",33);
            
            //read as a list
            //objectParentArray.ToList().ForEach(s=>Console.WriteLine(s));
            
            // convartion, but not safe
            //safe approach IEnumerable<T> provides only read-only access
            IEnumerable<Parent> objectParentArray = objectMaleChildrenArray;
             
            //runtime error give to me 
            //objectParentArray[0] = new FemailChild("anja","uk",33);
            
            //read as a list
            //objectParentArray.ToList().ForEach(s=>Console.WriteLine(s));
            


























    }
}





