using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace krasn23.a0z9.learning
{
    //krasn23.a0z9.learning.Program
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine(" --- Hi, c# learing! --- ");
            WriteLine(" -- Привет, c# тренинг! --- ");

            Write("Ваше имя: ");
            string name = ReadLine();
            WriteLine("Привет, " + name + "!");
            
        }
    }
}
