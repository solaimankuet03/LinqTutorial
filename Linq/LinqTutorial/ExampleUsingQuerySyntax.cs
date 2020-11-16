﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
    class ExampleUsingQuerySyntax
    {
        public static void Execute()
        {
            Console.WriteLine("Using Query Syntax");
            //Data Source
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            //LINQ Query using Query Syntax
            var QuerySyntax = from obj in integerList
                              where obj > 5
                              select obj;
            //Execution
            foreach (var item in QuerySyntax)
            {
                Console.Write(item + " ");
            }

            //Console.ReadKey();
        }
    }
}
