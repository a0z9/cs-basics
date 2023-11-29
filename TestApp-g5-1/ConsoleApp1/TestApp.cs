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
        static void GreetsTest() {
            WriteLine("KrasnYarsk 2023 c# learning base.Hi!");
            Write("Enter Name: ");
            string name = Console.ReadLine();

            WriteLine("Привет, " + name + "!");
            string message = $"Привет, {name}!";
            WriteLine(message);
            string message2 = String.Format("Salute, {0}!!", name);
            WriteLine("Привет, {0}!", name);
            WriteLine(message2);
            WriteLine("---------- Say Hello Func ---------");
            SayHello(name);
            WriteLine("---------- Say Hello Func from Class Hello ---------");
            Hello.SayHello(name);
            WriteLine("---------- Say Hello Func from Library ---------");
            Greets.SayHello(name);
        }
        static void NumbersTest() {

            //  byte, sbyte, short, ushort, int, uint, long, ulong
            //  float, double, decimal

            byte b1 = 11, b2 = 0b1011_1111, b3=067, b4=0xaf;
            byte b5;

           // checked
           // {
                b5 = (byte)(b1 + b2);
           // }

            WriteLine("b1={0} + b2={1} = b5={2} ",b1,b2,b5);

            int a = 111111;
            WriteLine(int.MinValue + " --- " + int.MaxValue + " ----- " + uint.MaxValue);
            WriteLine(1 << 35);
            ulong a2 = unchecked((ulong)(1L << 32));
            WriteLine(a2);
            WriteLine(Math.Pow(2,14) + " ---- " + (1<<14));


            ulong L1 = 1111110003424234L + 1;

            //-------------------------------------

            float f1 = 1.23456789012345678f;
            WriteLine(f1);
            double d1 = 1.23456789012345678, d2 = 100.234e-5;
            WriteLine(d1);





        }

        static void Main(string[] args)
        {
            // GreetsTest();
            NumbersTest();


            ReadKey();
        }
    }
}
