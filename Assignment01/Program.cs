﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero Superman = new Hero("Superman");
            Superman.show();
            Superman.hitAttempt(true);
        }
    }
}
