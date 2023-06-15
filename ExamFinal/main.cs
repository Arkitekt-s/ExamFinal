using ExamFinal;

class main
{
    static void Main(string[] args)
    {
        
        var myBooks = new List<Books>();
        {
            myBooks.Add(new Books { Title = "The AHobbit", Author = "J.R.R. Tolkien", Price = 10 });
            myBooks.Add(new Books { Title = "The BFellowship of the Ring", Author = "J.R.R. Tolkien", Price = 20 });
            myBooks.Add(new Books { Title = "The CTwo Towers", Author = "J", Price = 30 });
            myBooks.Add(new Books { Title = "The DReturn of the King", Author = "R Tolkien", Price = 40 });
        }
         var myBooks2 = new List<Books>();
         {
             myBooks2.Add(new Books { Title = "a", Author = "soheil", Price = 1 });
             myBooks2.Add(new Books { Title = "jbook", Author = "J", Price = 2 });
             myBooks2.Add(new Books { Title = "jboo2", Author = "J", Price = 3 });
             myBooks2.Add(new Books { Title = "d", Author = "merry", Price = 4 });
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
        //object initializer
        /*PersonClass person2 = new PersonClass
        {
            Name = "soheil",
        };
        Console.WriteLine(person2.ToString());*/
        
        //inheritance
        Ufo ufo1 = new Ufo("z489UFO", 40, "Mars");
        Console.WriteLine(ufo1.GetInfo());
        Ufo.Walking();
        Console.WriteLine(Ufo.NumberofPeople);
        
        
        
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





