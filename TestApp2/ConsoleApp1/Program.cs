using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ConsoleApp1.ConsoleUtils.Utils;
using static System.Console;
using  ConsoleApp1.ConsoleUtils;

namespace ConsoleApp1
{
    enum FileMode { 
     Read=1,
     Write=2,
     Execute=4
    }
    internal class Program
    {
        static void testParse() {
            string data = " 12 3 ";
            //  int i1 = int.Parse(data);
            int i1 = 0;
            if (int.TryParse(data, out i1))
            {
                WriteLine(++i1);
            }
            else
            {
                WriteLine("Wrong format!!!");
            }
        }
        static void Summator() {
            WriteLine("Summator, press 'x' to exit. Enjoy!");
            string s1, s2;
            int i1, i2;
            while (true) {
                Write("Number1: "); s1 = ReadLine();
                if (s1 == "x") { WriteLine("Bye!"); break; }
                Write("Number2: "); s2 = ReadLine();
                if (s2 == "x") { WriteLine("Bye!"); break; }

                if (int.TryParse(s1, out i1) && int.TryParse(s2, out i2)) WriteLine($"{i1} + {i2} = {i1 + i2}");
                else WriteLine("Wrong number format!!");
            }
        }
        static void testIfAndCycles() {

            // Блочная видимость
            { int a = 10; }
            { int a = 10; }

            int a0 = -10, a1 = 0, a2 = 11;
            if (a0 == 1) { }
            else if (a2 < 10) { }
            else if (a1 > -2) { }
            else { }

            FileMode fm = FileMode.Execute;
            switch (fm)
            {
                case FileMode.Read: WriteLine("Read!"); break;
                case FileMode.Write: WriteLine("Write!"); break; // goto label....
                case FileMode.Execute: WriteLine("Exec!"); break;
                case FileMode.Read | FileMode.Write: WriteLine("Read&Write"); break;
                case FileMode.Execute | FileMode.Read: WriteLine("Exec!"); break;
                default: WriteLine("Unknown mode!!"); break;
            }

            uint N = 1;
            WriteLine($"You have {N} apple" + ((N == 1) ? "." : "s."));

            // cycles;

            while (N < 5)
            {
                WriteLine("N=" + N);
                ++N;
            }

            Write("["); for (int i = 1; i < 6; i++) { Write(i + ","); }
            Write("\b]");
            // ||
            Write("[");
            {
                int i = 1;
                while (true)
                {
                    if (i >= 6) break;
                    Write(i + ",");
                    ++i;
                }
            }
            Write("\b]\n");

            // Search over massive data slice...

            for (int i = 1; i < 55; i++)
            {

                for (int k = 77; k > 1; k--)
                {
                    for (int j = 1; j < 177; j++)
                    {
                        //if(arr[i,j,k]==.....
                        if (i + j + 3 * k == 2 * i * j * k) { WriteLine(i + j + 3 * k + "=" + 2 * i * j * k); goto end_search; } // break
                    }
                }
            }
            end_search:

            int dw = -6;
            do { WriteLine("dw=" + dw--); }
            while (dw > 1);

            // foreach

        }
        static double Summa(double[] arr) {
            double summa=0;
            foreach (double d in arr) summa += d;
            return summa;
        }
        static double Summ(params double[] arr) {
            return Summa(arr);
        }
        static int[] GetRandomArray(int N = 10, int min = -100, int max = 100)
        {
            int[] arr = new int[N];
            Random random = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < N; i++) arr[i] = random.Next(min, max);
            return arr;
        }
        static void testArray() {
            double[] arr1 = new[] { 1.0, 2, 3 };
            double[] arr2 = new double[] { 1.99, 2, 3, 5, 77, 8.2, -33 };
            int[] arr4 = new int[] { 1, 2, 3, 5, 77, 8, -33, 4, 5, -2 };
            double[] arr3 = new double[10];
            arr3 = arr1;

            arr1[2] = 1.222;

            WriteLine($"[{String.Join(",", arr2)}]");
            Write("["); foreach (double d in arr2) { Write(d + ","); }
            Write("\b]\n");
            Write("["); foreach (double d in new double[12]) { Write(d + ","); }
            Write("\b]\n");
            WriteLine("S=" + Summa(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
            WriteLine("S2=" + Summ((byte)1, 2f, 3d, (short)4.0, 5, 6000000L, 7, 8, 9, 10));
            double dd = 1;
            printCollection(arr4);
            printCollection(GetRandomArray());
            int[] rarr = GetRandomArray(min: 10, max: 1000, N: 20);
            printCollection(rarr);
        }
        static bool F1(in int a, out int b, out int c) {

            b = a + 1; c = a - 1;
            return true;
        }
        static (int,int) F1(in int a)
        {
            int b, c;
            b = a + 1; c = a - 1; 
            return (b, c);
        }

        static void TrySwap(int a, int b){
            int c = b; b = a; a = c;
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T c = b; b = a; a = c;
        }

        static void Main(string[] args)
        {
            //testParse();
            //Summator();
            //testIfAndCycles();
            //testArray();
            int c1=10, c2, c3;
            if(F1(c1, out c2, out c3)) WriteLine($"F1 success! c2={c2}, c3={c3}");
            (c2, c3) = F1(c1);
            WriteLine($"F1 success! c2={c2}, c3={c3}");

            (int v1, int v2) tuple = F1(100);
            WriteLine($"F1 success! tuple.v1={tuple.v1}, tuple.v2={tuple.v2}");

            WriteLine("----------- Swap test ------------");

            int x = 111, y = 222;
            WriteLine($"x={x}, y={y}.");
            TrySwap(x, y);
            WriteLine($"x={x}, y={y}.");
            
            Swap<int>(ref x, ref y);
            WriteLine($"x={x}, y={y}.");

            WriteLine("----------- String test ------------");

            string calc_str = "  12      +   13 "; // 12+ 33
            string calc_str2 = "    12 +13   ";
            calc_str = calc_str.Trim();
            string[] sarr = calc_str.Split(new char[] {' ','\t'}, StringSplitOptions.RemoveEmptyEntries);
            Utils.printCollection(sarr);
            int idx = calc_str2.IndexOf("+");
            if (idx != -1)
            { 
              string left = calc_str2.Substring(0, idx);
              string right = calc_str2.Substring(++idx);
              left = left.Trim();
              right = right.Trim();

              WriteLine($"{left} + {right}");

            }

            // int a = 10;
            ReadKey();
        }
    }
}
