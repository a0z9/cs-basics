using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

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


            return summa;
        }

        static void Main(string[] args)
        {
            //testParse();
            //Summator();
            //testIfAndCycles();
            double[] arr1 = new[] { 1.0, 2, 3 };
            double[] arr2 = new double[] { 1, 2, 3,5,77,8,-33 };
            double[] arr3 = new double[10];
            arr1[2]=1.222;

            WriteLine($"[{String.Join(",",arr2)}]");
            Write("["); foreach(double d in arr2) { Write(d + ","); } Write("\b]");
            Write("["); foreach (double d in new double[12]) { Write(d + ","); } Write("\b]");



            // int a = 10;
            ReadKey();
        }
    }
}
