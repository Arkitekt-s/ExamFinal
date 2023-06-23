namespace ExamFinal;

public class mainLinq
{
    public static void mainLinq1()

    {
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n" + new string('*', 10) + "Linq Methods" + new string('*', 10));
        Console.ResetColor();
        
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
        //without using linq
        foreach (var book in myBooks)
        {
            if (book.Author == "J.R.R. Tolkien")
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
            .OrderBy(x => x.Title).ThenBy(x => x.Price)
            .Select(x => x.Title);
        foreach (var Book in myNewBooks)
        {
            Console.WriteLine(Book);
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
                Console.WriteLine("grope by Title: " + book.Title);
            }
        }
       
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n" + new string('*', 10) + "Linq Query syntax" + new string('*', 10));
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
            
    





    