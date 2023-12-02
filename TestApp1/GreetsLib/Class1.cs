using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
namespace GreetsLib
{
    public class Greets
    {
        public static void SayGreets(string name, string greets = "Hi")
        {
            WriteLine($"!!!{greets}, {name}!");
        }
    }
}
