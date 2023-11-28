using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hello.krasn23.a0z9.learning;
using static System.Console;

namespace krasn23.a0z9.learning
{
    class TestVariables
    {
        static void SayHello(string name)
        {
            WriteLine($"Салют, {name}!");
        }

        static void Main(string[] args)
        {
            WriteLine("G3 c# training! Hi all!");
            Write("Ваше имя: "); 
            string name = ReadLine();

            WriteLine("Привет, " + name + "!!");
            WriteLine($"Привет, {name}!!");
            WriteLine("Привет, {0}!!",name);
            SayHello(name);
            Hello.SayHello(name);



            ReadKey();
        }
    }
}
