using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using greets.a0z9.libs;
using hello.krasn23.a0z9.learning;
using static System.Console;

namespace krasn23.a0z9.learning
{
    internal class TestApp
    {
        static void SayHello(string name) {
            
            WriteLine($"HowDoUDo, {name}!");
        }

        static void Main(string[] args)
        {
            WriteLine("KrasnYarsk 2023 c# learning base.Hi!");
            Write("Enter Name: ");
            string name = Console.ReadLine();
            
            WriteLine("Привет, " + name + "!");
            string message = $"Привет, {name}!";
            WriteLine(message);
            string message2 = String.Format("Salute, {0}!!", name);
            WriteLine("Привет, {0}!",name);
            WriteLine(message2);
            WriteLine("---------- Say Hello Func ---------");
            SayHello(name);
            WriteLine("---------- Say Hello Func from Class Hello ---------");
            Hello.SayHello(name);
            WriteLine("---------- Say Hello Func from Library ---------");
            Greets.SayHello(name);

            ReadKey();
        }
    }
}
