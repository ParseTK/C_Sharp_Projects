using static System.Console;

namespace Object_Methods_SET_GET_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Chamber of Secrets", "J.K. Rowlings", 432, 3);
            Book book2 = new Book("Lord of The Rings", "J.R.R Tolkien", 852, 5);

            WriteLine("Uploading books.... ");

            WriteLine();

            WriteLine(book1.title);
            WriteLine(book1.author);
            WriteLine(book1.pages);
            WriteLine("Stars out of 5: {0}", book1.Rating);

            WriteLine();

            WriteLine(book2.title);
            WriteLine(book2.author);
            WriteLine(book2.pages);
            WriteLine("Stars out of 5: {0}", book2.Rating);

            WriteLine();

            Write("Does the book have 100 or more pages? ");
            WriteLine(book1.HasPageHundred());

            Write("Does the book have 100 or more pages? ");
            WriteLine(book2.HasPageHundred());

            ReadLine();
        }
    }
}
