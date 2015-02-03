// Developer: Beymig Munoz Martinez
// Date Last Modified: Jan 28th 2015
// Program Description: A program that generates Hero abilities and allows him to hit a villain (or not)

  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        //creates the new hero and calls the required methods
        static void Main(string[] args)
        {
            Hero Superman = new Hero("Superman");`
            Superman.show();
            Superman.fight();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
