using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace ConsoleApp1.ConsoleUtils
{
    public static class Utils
    {
        public static void printCollection(IEnumerable data) 
        {
            Write("["); foreach (var d in data) { Write(d + ","); }  Write("\b]\n");
        }

    }
}
