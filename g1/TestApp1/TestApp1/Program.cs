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

        private static void SayHello(string name)
        {
            System.Console.WriteLine($"Salute! Салют, {name}!");
        }

        private static void TestHello() {
            WriteLine("Hi, Sfu!!");

            Write("Enter Name: "); var name = ReadLine();

            WriteLine($"Hi, {name}!");
            WriteLine("Hi, {0}!", name);
            string output = String.Format("Привет, {0}", name);
            WriteLine(output);
            Hello.SayHello(name);
            SayHello(name);
        }


        private static void TestCalculus() {
            // Convert and Parse
            // simple calc
            WriteLine("Calc - summator v.1, press 'x' to exit. Enjoy.");
            while (true)
            {
                Write("Enter number1: "); string ds1 = ReadLine(); if (ds1 == "x") break;
                int data1 = int.Parse(ds1);
                Write("Enter number2: "); string ds2 = ReadLine(); if (ds2 == "x") break;
                int data2 = int.Parse(ds2);
                WriteLine($"{data1} + {data2} = {data1 + data2}");
            }

            WriteLine("Calc - summator v.2, press 'x' to exit. Enjoy.");
            while (true)
            {
                Write("Enter number1: "); string ds1 = ReadLine();
                Write("Enter number2: "); string ds2 = ReadLine();
                if (ds1 == "x" || ds2 == "x") break;
                int summa = 0, data2 = 0, data1 = 0;

                if (!int.TryParse(ds1, out data1) || !int.TryParse(ds2, out data2))
                {
                    WriteLine("Wrong number format, try again or press x to exit...");
                    continue;
                }
                else 
                {
                    checked { summa = data1 + data2; }

                }
              
                WriteLine($"{data1} + {data2} = {summa}");
            }

        }
        private static void TestNumbers() {
            //checked
            //{
                byte b0 = 1, b1 = 130;
                byte b2 = (byte)(b0 + b1);
                WriteLine($"Result byte: {b2}");
            //}

            unchecked
            {
                sbyte sb0 = (sbyte)(0b1111_1111);//sb0 +1 = 1_0000_0000
                WriteLine($"Result byte: {sb0}");
            }

            short sh = 1234;
            WriteLine($"Short Min: {short.MinValue}, Max:{short.MaxValue}");

            ushort ush = 1234;
            WriteLine($"UShort Min: {ushort.MinValue}, Max:{ushort.MaxValue}");

            int a;
            long L1;
            WriteLine($"ULong Min: {ulong.MinValue}, Max:{ulong.MaxValue}");

            byte b7 = 0b1111;
            WriteLine($"Byte {b7}, << {b7<<1}, >> {b7>>1}");

            int i1 = 3;
            int res = i1 << 10;

            long L2 = 1333765376537653L;

            // float,double --------------
            float f1 = (float)1.23456789012345678901;
            WriteLine($"f1={f1}");

            double d1 = 1.23456789012345678901;
            WriteLine($"d1={d1}");

            //-----------------------------

            char ch1 = 'a', ch2 = (char)65;
            WriteLine($"ch1={ch1}, ch2={ch2}");

            // String
            string s1 = "Hi string!!!";

         


        }
        static void Main(string[] args)
        {
            {
                foreach (var arg in args) Write(arg + ", ");
                if(args.Length >0) Write("\b\b.\n");
            }
            //TestHello();
            TestNumbers();
            //TestCalculus();

            int a=0,b=0,i=0;
            ++b;

            int res = a++ + --b - --i + b++;
            WriteLine("----------------");
            while (i++ < 5) WriteLine(i);
            WriteLine("----------------");



            WriteLine(res);
        ReadLine();


        }
    }
}
