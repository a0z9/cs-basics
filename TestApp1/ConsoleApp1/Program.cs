using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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

        static void GreetsTest()
        {
            WriteLine(" --- Hi, c# learing! --- ");
            WriteLine(" -- Привет, c# тренинг! --- ");

            Write("Ваше имя: ");
            string name = ReadLine();

            WriteLine("Привет, " + name + "!");
            WriteLine($"Salute, {name}!");
            WriteLine("Салют, {0}!", name);
            string greets = String.Format("How do U do, {0}!", name);
            WriteLine(greets);

            SayGreets(name);
            SayGreets(name, "Как дела");

            GreetsUtils.SayGreets(name);
            GreetsLib.Greets.SayGreets(name);

        }

        private static void Main(string[] args)
        {
            //  GreetsTest();
        Thread.CurrentThread.CurrentCulture=
                System.Globalization.CultureInfo.InvariantCulture;

        byte b1 = 111, b2 = 0b1100_1101, b3=027, b4=0x0f;
       
        byte res;
          //  checked
          //  {
                res = (byte)(b1 + b4 + 12);
          // }
        WriteLine((b1 + b4 + 12) + " ---- " + res);
        sbyte sb = -22;
        short sh = 1234;
        WriteLine($"Min short: {short.MinValue}, Max short: {short.MaxValue}.");

        int d1 = 11;
        WriteLine($"Max uint: {uint.MaxValue}, Max uint: {(1L<<32)-1}.");

        ulong L1 = 123131313123uL;
            unchecked
            {
                WriteLine($"Max long: {long.MaxValue}, Max uint: " +
                   $"{(1L << 63) - 1}.");
            }
            WriteLine("long digits: " + Math.Log10(long.MaxValue));

            //------------------------
            float f1 = 1.2345678901234567890f;
            WriteLine("f1=" + f1);
            double dd1 = 1.2345678901234567890;
            WriteLine("d1=" + dd1);
            // 1.13123e-22
            decimal dec = 1.234567890123456789012345678901234567890123m;
            WriteLine("dec=" + dec);



            ReadKey();
        }
    }
}
