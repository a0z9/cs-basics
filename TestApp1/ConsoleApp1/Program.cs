using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using greets.krasn23.a0z9.learning;
using static System.Console;

namespace krasn23.a0z9.learning
{
    //krasn23.a0z9.learning.Program
    internal class Program
    {
        private static void SayGreets(string name, string greets = "Салют")
        {
            WriteLine($"!{greets}, {name}!");
        }

        private static void Main(string[] args)
        {
            WriteLine(" --- Hi, c# learing! --- ");
            WriteLine(" -- Привет, c# тренинг! --- ");

            Write("Ваше имя: ");
            string name = ReadLine();

            WriteLine("Привет, " + name + "!");
            WriteLine($"Salute, {name}!");
            WriteLine("Салют, {0}!",name);
            string greets = String.Format("How do U do, {0}!", name);
            WriteLine(greets);
           
            SayGreets(name);
            SayGreets(name,"Как дела");

            GreetsUtils.SayGreets(name);




        }
    }
}
