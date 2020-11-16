﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleUsingQuerySyntax.Execute();
            Console.WriteLine();
            ExampleUsingMethodSyntax.Execute();
            Console.WriteLine();
            ExampleUsingMixedSyntax.Execute();

            Console.ReadKey();
        }
    }
}
