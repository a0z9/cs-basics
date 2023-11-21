//using hello.krasn2023.sfu.training;
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

        private static void TestNumbers() {

            byte b1 = 12, b2 = 0b1111_1110, b3 = 0xaf, b4 = 073;
            byte b5 = 254;

            byte b6=0;
            unchecked {b6 = (byte)(b1 + b5); }

            sbyte sb1 = 0b0111_1111;

            ushort sh1 = 0xffff;
            WriteLine(sh1 + " -- " + ushort.MaxValue);

            uint i = 12;
            ulong L1 = 278136186378133L;
            WriteLine("ulong max: " + ulong.MaxValue);

            WriteLine($"b6={b6}");
            //--------------------------------
            int i1 = 0, i2 = 0, i3 = 0, res1 = 0;
            --i2; // i2=-1
            res1 = ++i1 - --i2 + ++i3 - i3++;
            WriteLine("res=" + res1);

            // bit ops
            WriteLine("res << 3: " + (res1<<3));
            WriteLine("res >> 1: " + (res1 >> 1));

            byte b21 = 0b1011_0101;
            //    b2 = 0b1111_1110  (0001_0000)
            byte res3 = (byte) ( b21 & b2);
            byte res4 = (byte)(b21 | b2);
            byte res5 = (byte)(b21 ^ b2 ^ b2); // XOR

            WriteLine("b2  " + Convert.ToString(b2, 2));
            WriteLine("b21 " + Convert.ToString(b21, 2));
            WriteLine("&:  " + Convert.ToString(res3,2));
            WriteLine("|:  " + Convert.ToString(res4, 2));


            //---------------------------------
            // floats

            float f1 = (float)1.234567890123456789;
            WriteLine($"f1={f1}");

            double d1 = 1.234567890123456789;
            WriteLine($"d1={d1}");

            //--------

            bool res;


        }

        static void Main(string[] args)
        {

            //SayGreets();
            //SayGreets(true);
            //hello.krasn2023.sfu.training.Hello.SayGreets();

            // TestNumbers();
            WriteLine("Calculator - summator, enter 'x' to exit.");
            
                while (true)
                {
                    Write("Enter number1: "); string str1 = Console.ReadLine();

                    Write("Enter number2: "); string str2 = Console.ReadLine();
                    if (str1 == "x" || str2 == "x") { WriteLine("By!"); break; }
                    //int d1 = int.Parse(str1);
                    //int d2 = int.Parse(str2);
                    int res = 0, d1 = 0, d2 = 0;
                    if (!int.TryParse(str1, out d1) || !int.TryParse(str2, out d2))
                    {
                        WriteLine("Wrong number format.."); continue;
                    }

                    checked { res = d1 + d2; }
                    WriteLine($"{d1} + {d2} = {res}");
                }
            
            {
                int res = 0;

            }
            

            ReadLine();


        }
    }
}
