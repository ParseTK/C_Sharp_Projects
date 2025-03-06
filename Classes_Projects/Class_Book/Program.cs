using static System.Console;

namespace Practice_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Title of the book here";
            book1.description = "A description of the book here";
            book1.author = "The author of the book here";
            book1.pages = 623; // number of total pages here.

            Book book2 = new Book();
            book2.title = "Chamber of Secrets";
            book2.description = "A harry potter book";
            book2.author = "J.K. Rowling";
            book2.pages = 400; // number of total pages here.

            WriteLine(book1.title);
            WriteLine(book1.author);
            WriteLine(book1.description);
            WriteLine(book1.pages);

            WriteLine();

            WriteLine(book2.title);
            WriteLine(book2.author);
            WriteLine(book2.description);
            WriteLine(book2.pages);

            ReadLine();

        }

    }
}