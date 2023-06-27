namespace ExamFinal;

public class mainLinq
{
    public static void mainLinq1()

    {
        
         
        
        var myBooks = new List<BookLinq>();
        {
            myBooks.Add(new BookLinq { Title = "The A-Hobbit", Author = "J.R.R. Tolkien", Price = 20 });
            myBooks.Add(new BookLinq { Title = "The B-Fellowship of the Ring", Author = "J.R.R. Tolkien", Price = 10 });
            myBooks.Add(new BookLinq { Title = "The C-Two Towers", Author = "J", Price = 30 });
            myBooks.Add(new BookLinq { Title = "The D-Return of the King", Author = "J.R.R. Tolkien", Price = 40 });
        }
        var myBooks2 = new List<BookLinq>();
        {
            myBooks2.Add(new BookLinq { Title = "a", Author = "soheil", Price = 1 });
            myBooks2.Add(new BookLinq { Title = "j-book1", Author = "J", Price = 2 });
            myBooks2.Add(new BookLinq { Title = "j-book2", Author = "J", Price = 3 });
            myBooks2.Add(new BookLinq { Title = "d", Author = "merry", Price = 4 });
        }
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n" + new string('*', 50)+ "Linq Method" + new string('*', 50));
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n" + new string('*', 10) + "without using linq" + new string('*', 10));
        Console.ResetColor();
        //without using linq
        foreach (var book in myBooks)
        {
            if (book.Author == "J.R.R. Tolkien")
            {
                Console.WriteLine(book.Title);
            }
        }
        

        //Where: Filters a sequence of elements specifying a condition
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n" + new string('*', 10) + "Linq Where" + new string('*', 10));
        Console.ResetColor();
        var myNewBooks1 = myBooks.Where(x => x.Price == 10);
        foreach (var Books1 in myNewBooks1)
        {
            Console.WriteLine("spesific the condition using where: " + Books1.Title);
        }
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n" + new string('*', 10) + "Linq Select" + new string('*', 10));
        Console.ResetColor();

        //Select: Projects each element of a sequence into a new form
        var myNewBooks2 = myBooks.Select(x => x.Title);
        foreach (var Books2 in myNewBooks2)
        {
            Console.WriteLine("specify what specific data you want to select using select: " + Books2);
        }
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n" + new string('*', 10) + "Linq GropeBy" + new string('*', 10));
        Console.ResetColor();
        
        var myNewBooks66 = myBooks.GroupBy(x => x.Author);
         foreach (var Books66 in myNewBooks66)
         {
             Console.WriteLine($"GroupBy: {Books66.Key}");
             
         }
        
        
        
        
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n" + new string('*', 10) + "Linq Orderby" + new string('*', 10));
        Console.ResetColor();

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
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n" + new string('*', 10) + "Linq first/last" + new string('*', 10));
        Console.ResetColor();
        //first
        var myNewBooks10 = myBooks.First(x => x.Price > 10);
        Console.WriteLine("first the collection using first: " + (myNewBooks10 == null ? "null" : myNewBooks10.Title));
        //last
        var myNewBooks11 = myBooks.Last(x => x.Price > 35);
        Console.WriteLine("last the collection using last: " + (myNewBooks11 == null ? "null" : myNewBooks11.Title));
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n" + new string('*', 10) + "Linq sum-average-max-min" + new string('*', 10));
        Console.ResetColor();
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
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n" + new string('*', 10) + "Combination of LINQ extension methods1" + new string('*', 10));
        Console.ResetColor();
        var myNewBooks = myBooks.Where(x => x.Author == "J.R.R. Tolkien")
            .OrderBy(x => x.Title).ThenBy(x => x.Price)
            .Select(x => x.Title);
        foreach (var Book in myNewBooks)
        {
            Console.WriteLine(Book);
        }
        // LINQ (Language-Integrated Query) 
        //grope by author of to list of mybooks and mybooks2
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n" + new string('*', 10) + "Combination of LINQ extension methods2" + new string('*', 10));
        Console.ResetColor();
        var mergedBooks = myBooks.Concat(myBooks2);
        var myNewgroup = mergedBooks.GroupBy(x => x.Author)
            .ToDictionary(x => x.Key, x => x.ToList());
        foreach (var Books in myNewgroup)
        {
            Console.WriteLine("grope by author: " + Books.Key);
            foreach (var book in Books.Value)
            {
                Console.WriteLine("grope by Title: " + book.Title);
            }
        }
       
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n" + new string('*', 10) + "Linq Query syntax1" + new string('*', 10));
        Console.ResetColor();
        //Query Syntax:
        var query = from book in myBooks
            where book.Author == "J.R.R. Tolkien"
            orderby book.Title
            select book.Title;
        foreach (var title in query)
        {
            Console.WriteLine("Query Syntax title: " + title);
        }
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n" + new string('*', 10) + "Linq Query syntax2" + new string('*', 10));
        Console.ResetColor();
        //other Query Syntax:
        var query2 = from book in myBooks
            where book.Price > 10
            orderby book.Title
            select book.Title;
        foreach (var title in query2)
        {
            Console.WriteLine("Query Syntax price: " + title);
        }
        //with color
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n" + new string('*', 10) + "Custom extension method" + new string('*', 10));
        Console.ResetColor();
        //Use the extension method to filter books by author
        var FilteredBooks = BookExtensionsLinq.FilterByAuthor(myBooks,"J");
        foreach (var book in FilteredBooks)
        {
            //give a list
            Console.WriteLine("Custom extension(FilterByAuthor) method: " + book.Title);
        }
        
    }
}
            
    





    