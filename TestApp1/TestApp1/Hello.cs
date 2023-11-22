using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace hello.krasn2023.sfu.training
{
    internal class Hello
    {
        public static void SayGreets(bool ask = false, string name = "Andrei")
        {
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("Hi, SFU!");

            if (ask)
            { Write("Введите имя: "); name = ReadLine(); }

            WriteLine($"Привет, {name}!");
            WriteLine("How do you do, " + name + "!");
            var greets = "Как дела, " + name + "!";
            WriteLine(greets);
            greets = String.Format("Салют, {0}!", name);
            WriteLine(greets);
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
        }

    }
}
