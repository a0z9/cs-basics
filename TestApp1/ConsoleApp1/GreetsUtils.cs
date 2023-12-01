using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace greets.krasn23.a0z9.learning
{
    internal class GreetsUtils
    {
        public static void SayGreets(string name, string greets = "Салют")
        {
            WriteLine($"{greets}, {name}!!!");
        }

    }
}
