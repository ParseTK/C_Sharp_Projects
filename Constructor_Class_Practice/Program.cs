using Class_Constructors_Practice;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("Chamber of Secrets", "J.K. Rowlings", 432);
        Book book2 = new Book("Lord of The Rings", "Unknown Author", 852);

        WriteLine("Uploading books.... ");

        WriteLine();

        WriteLine(book1.title);
        WriteLine(book1.author);
        WriteLine(book1.pages);
        
        WriteLine();

        WriteLine(book2.title);
        WriteLine(book2.author);
        WriteLine(book2.pages);

        ReadLine();
    }
}