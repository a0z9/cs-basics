﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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
        static void HelloTest() {

            WriteLine("G3 c# training! Hi all!");
            Write("Ваше имя: ");
            string name = ReadLine();

            WriteLine("Привет, " + name + "!!");
            WriteLine($"Привет, {name}!!");
            WriteLine("Привет, {0}!!", name);

            SayHello(name);
            Hello.SayHello(name);
            Hello2.SayHello(name);
        }
        static int Summator(string s1, string s2) {

            //int a1 = int.Parse(s1);
            // int a2 = int.Parse(s2);
            int a1 = 0, a2 = 0;
            if (int.TryParse(s1, out a1) && int.TryParse(s2, out a2))
            { return a1 + a2; }
            WriteLine("Wrong format!!!"); return 0;
        }
        static void Summator()
        {
            WriteLine("Summator of int, press 'x' to exit.");
            int a1, a2;
            string s1, s2;
           
            while (true)
            {
                Write("Number1="); s1=ReadLine();
                Write("Number2="); s2 = ReadLine();
                if( s1=="x" || s2 == "x") { WriteLine("By."); break; }

                if (int.TryParse(s1, out a1) && int.TryParse(s2, out a2))
                { WriteLine($"{a1} + {a2} = {a1 + a2}"); }
                else { WriteLine("Wrong format!!!"); } 
            }
        }
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture =
                    System.Globalization.CultureInfo.InvariantCulture;
            
            // HelloTest();

            //------------ Numbers ------------------
            WriteLine("------------ Numbers ------------------");
            byte b1 =  unchecked((byte)1123);
            WriteLine($"{b1} -- {Convert.ToString(b1, 2)}");
            sbyte sb1 = 121, sb2 = 6;
            sbyte sb3;

         //   checked
         //   {
                sb3 = (sbyte)(sb1 + sb2);
         //   }

            WriteLine($"{sb3} -- {Convert.ToString(sb3, 2)}");

            short sh1 = 1234, sh2 = 0x1f_ff;
            WriteLine($"{short.MaxValue,6}, {short.MinValue,6} ");
            WriteLine($"{(1<<15)-1,6}, {-(1 << 15),6} ");
            WriteLine("------------------------------");

            int i1 = 1111111;

            unchecked
            {
                WriteLine($"{int.MaxValue,10}, {int.MinValue,10} ");
                WriteLine($"{(1 << 31) - 1,10}, {-(1 << 31),10} ");
            }

            // 0001_1100 
            // << 1
            // 0011_1000

            unchecked
            {
                WriteLine($"{long.MaxValue,10}, {long.MinValue,10} ");
                WriteLine($"{(1L << 63) - 1,10}, {-(1L << 63),10} ");
                WriteLine($"{ulong.MaxValue,10}, {ulong.MinValue,10} ");
            }

            // --- floats ----

            float f1 = 1234.5678901234567890f;  // 1.2345678901234567890e3
            WriteLine("Float Precision:" + Math.Log10(1 << 23));
            WriteLine($"f1={f1}");

            //

            // --- doubles ----

            double d1 = 1234.5678901234567890;  // 1.2345678901234567890e3
            WriteLine("Double Precision:" + Math.Log10(1L << 52));
            WriteLine($"d1={d1}");

            // --- decimal ----
            WriteLine(" ------------ Decimal test  ----------------- ");
            decimal dc = 1m / 3m;
            double  dd = 1d / 3d;

            WriteLine(dc);
            WriteLine(dd);

            dc = (0.3m + 0.3m + 0.3m)/0.2m;
            dd = (0.3 + 0.3 + 0.3)/0.2;

            WriteLine(dc);
            WriteLine(dd);

            //------------- Operators ----------------------

            // ++, --, +=, -=, ... &,|, !, ^

            dd = dd * 1.01; // dd *= 1.01;

            int a1 = 0b1011_1100;
            int a2 = 0b1100_1001;

            WriteLine($"{"a1=",5} {Convert.ToString(a1,2),10}");
            WriteLine($"{"a2=",5} {Convert.ToString(a2,2),10}");
            WriteLine($"{"a1&a2",5} {Convert.ToString(a1 &a2,2),10}");
            WriteLine($"{"a1|a2",5} {Convert.ToString(a1|a2,2),10}");
            WriteLine($"{"a1^a2",5} {Convert.ToString(a1 ^a2,2).PadLeft(8,'0'),10}");
            unchecked
            {
                WriteLine($"{"~a1",5} {Convert.ToString((byte)~a1, 2).PadLeft(8, '0'),10}");
            }

            int k1 = 1 , k2 = 1, k3 = 1, res=0;

            res = ++k1 - --k2 + --k3 - k3++ + --res;
            //2 - 0 + 0 - 0 -1
            k1++;
            ++k1;

            WriteLine("res=" + res);

            //--------------------------------------------------
            WriteLine("----------- Summator test -----------");
           
            WriteLine(Summator("12s3  ", " -23 " ));
            Summator();


            ReadKey();
        }
    }
}
