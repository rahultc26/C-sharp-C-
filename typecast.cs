﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typecast
{
    class Example
    { 
        class Program { }

    static void Main(string[] args)
    {
        Example e = new Example();
        Program P = (Program)e;
        Console.Read();
    }
    }
}
