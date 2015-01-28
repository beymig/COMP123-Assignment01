using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {
        //creates the new hero and calls the required methods
        static void Main(string[] args)
        {
            Hero Superman = new Hero("Superman");
            Superman.show();
            Superman.fight();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
