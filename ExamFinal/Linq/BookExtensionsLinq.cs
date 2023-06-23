namespace ExamFinal;
//this a linq extention method should be in a static class and static method

public static class BookExtensionsLinq
{
    public static List<BookLinq> FilterByAuthor(this List<BookLinq> books, string author)
    {
        return books.Where(x => x.Author == author).ToList();
    }
}