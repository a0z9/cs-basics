using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace gencollections.krasn23.learning
{
    internal class Program
    {
        static void printCollection(IEnumerable col)
        {
            Write("{"); foreach (var d in col) Write(d + ", ");
            WriteLine("\b\b}");
        }

        static void Main(string[] args)
        {
            Box<int> box = new Box<int>(3);
            box.Add(100);
            box.Add(3000);
            box.Add(-300);
            box.Add(-440);

            printCollection(box);

        
        }
    }
}
