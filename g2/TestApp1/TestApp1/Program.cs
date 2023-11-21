using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace krasn2023.sfu.training
{
    internal class Sfu
    {
        private static void SayGreets(bool ask = false, string name = "Andrei") {
            WriteLine("Hi, SFU!");

            if (ask)
            { Write("Введите имя: "); name = ReadLine(); }

            WriteLine($"Привет, {name}!");
            WriteLine("How do you do, " + name + "!");
            var greets = "Как дела, " + name + "!";
            WriteLine(greets);
            greets = String.Format("Салют, {0}!", name);
            WriteLine(greets);
        } 

        static void Main(string[] args)
        {
            SayGreets();
            SayGreets(true);

            ReadLine();


        }
    }
}
