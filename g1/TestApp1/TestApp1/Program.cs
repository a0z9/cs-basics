using hello.krasn2023.learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace krasn2023.learning
{   class Sfu
    {

        static void SayHello(string name)
        {
            System.Console.WriteLine($"Salute! Салют, {name}!");
        }
        static void Main(string[] args)
        {
            WriteLine("Hi, Sfu!!");
            
            Write("Enter Name: "); var name = ReadLine();

            WriteLine($"Hi, {name}!");
            WriteLine("Hi, {0}!",name);
            string output = String.Format("Привет, {0}", name);
            WriteLine(output);
            Hello.SayHello(name);
            SayHello(name);




        }
    }
}
