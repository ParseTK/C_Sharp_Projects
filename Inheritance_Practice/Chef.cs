using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inheritance_Practice
{
    class Chef
    {
        public void MakeChicken()
        {
            WriteLine("The chef makes chicken");

        } public void MakeTurkey()
        {
            WriteLine("The chef makes turkey");

        } public void MakeBeef()
        {
            WriteLine("The chef makes beef");

        } 
        public virtual void MakeClams()
        {
            WriteLine("The chef makes clams");

        }
    }
}
