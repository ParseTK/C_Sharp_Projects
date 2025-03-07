using static System.Console;

namespace Inheritance_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            HeadChef headChef = new HeadChef();
            chef.MakeClams();
            WriteLine();

            headChef.MakeClams();
            headChef.MakeLobster();
            
            ReadLine();
        }
    }
}
