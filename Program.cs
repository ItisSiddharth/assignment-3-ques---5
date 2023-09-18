
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("As3")]

namespace Assignment3
{
    internal class Program
    {
        internal String name = "SAT";
        protected internal void getName()
        {
            Console.WriteLine(name);
        }

    }

}

Assembly2 -

using Assignment3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace As3
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Assignment3.Program program = new Assignment3.Program();
            program.getName();
            Console.ReadLine();
        }
    }
}
