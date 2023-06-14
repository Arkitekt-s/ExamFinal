namespace ExamFinal;
//this a linq extention method

public static class BookExtensions
{
    public static List<Books> FilterByAuthor(this List<Books> books, string author)
    {
        return books.Where(x => x.Author == author).ToList();
    }
}