using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace krasn2023.sfu.training
{


    internal class Program
    {

        private static string EchoDelim(string s="-", int N=65)
        {
            // only training
            string res = s;
            for (int i = 1; i < N; i++) res += s;
            return res;
        }

        enum FileAcces
        {
           Read=1,     //0b0001
           Write=2,    //0b0010
           Execute=4,  //0b0100
           Append=8    //0b1000
        }

        private static void TestLoops() {
            int i1 = 3;

            if (i1 == 30)
            {

            }
            else
            {

            }

            int sw = 3;

            if (sw > 10)
            { }
            else if (sw > 5)
            { }
            else if (sw > 2)
            { }
            else
            { }

            string flag = "r";

            switch (flag)
            {
                case "w": Console.WriteLine("flag W"); break;
                // ...
                default: Console.WriteLine("def. value"); break;
            }

            FileAcces fa = FileAcces.Write | FileAcces.Read;

            switch (fa)
            {
                case FileAcces.Write:
                case FileAcces.Append:
                    Console.WriteLine("Write"); break;
                case FileAcces.Read: Console.WriteLine("Read"); break;
                case FileAcces.Read | FileAcces.Write:
                    Console.WriteLine("Read & Write"); break;
                //---------------------
                default: WriteLine("No mode.."); break;
            }

            int N = 10;
            WriteLine($"Class has {N} student" + ((N != 1) ? "s." : "."));

            //-------------------------------------------------

            {
                int i = 0;
                while (i < 5)
                {
                    Write(i + ", ");
                    ++i;
                }
                WriteLine("\b\b.");
            }
            //------------

            {
                int i = 0;
                while (true)
                {
                    if (i >= 5) break;
                    Write(i + ", ");
                    ++i;
                }
                WriteLine("\b\b.");
            }
            WriteLine("---------------------");
            {
                int i = 1;
                do
                {
                    Write(i + ", ");
                    ++i;
                }
                while (i < 3);
            }

            for (int i = 0; i < 5; i++) WriteLine("-> " + i);
            WriteLine(EchoDelim());

            for (int i = 0; i < 5; i++) WriteLine("-> " + i);

            WriteLine("---------------------");
            {
                int i = 0;
                for (; ; )
                {
                    if (i >= 5) break;
                    WriteLine("> " + i);
                    ++i;
                }
            }

            // int i = 2;

        }

        private static int[] GenArray(int N=10, int min=-10, int max = 10) { 
        int[] arr = new int[N];
            var rnd = new Random((int)DateTime.Now.Ticks);

            for(int i=0; i<N; i++) arr[i] = rnd.Next(min, max);
            return arr;

        }

        private static void TestArrays()
        {
            int[] arr1 = new int[10];
            int[] arr2 = { 1, 2, 3, -29, 3, 4 };
            int i = 5;

           // WriteLine($"arr2[{i}] = {arr2[i]}");
            for (int k = 0; k < arr2.Length; k++) WriteLine($"arr2[{k}] = {arr2[k]}");
            foreach(int val in arr2) WriteLine($"{val}");

            WriteLine($"[{String.Join(",", GenArray())}]");

            //------------------
            int[,] matrix1 = new int[2, 3];
            int[,] matrix2 = { {1,2,3}, {-2,-4,3 }, {0,-3,2} };
                        
            //-------------------
            int[][] jarr = new int[2][];
            jarr[0] = new int[3];
            jarr[1] = new int[2];

            //--------------------

//#practice
            //      1   2   3 
            //  1   1
            //  2   2   4   6
            //  3

        }

        static void Multic(int x = 10, int y = 10)
        {
            for (int ix = 1; ix <= x; ix++) Write($"\t{ix}");
            WriteLine();
            for (int iy = 1; iy <= y; iy++)
            {
                Write($"{iy}\t");
                for (int ix = 1; ix <= x; ix++) Write($"{ix * iy}\t");
                WriteLine();
            }
        }

        static (int a, int b) getValues() {
            // claculus
            int aa = 1988, bb = -898;
            return (aa, bb);
          
        }

        static bool getValues(out int a, out int b)
        {
            // calculus
            a = 2023; b = 1898;
            return true;

        }


        static int Summa(int[] arr) {
            int s = 0;
            foreach (int a in arr) s += a;
            return s;
        
        }

        static int Summa2(int mult, params int[] arr)
        {
            int s = 0;
            foreach (int a in arr) s += a;
            return s*mult;

        }

        static string[] validArgs = { "/h", "--help", "-h" };

        static void Main(string[] args)
        {
            // TestLoops();
            // TestArrays();
            // Multic();
            WriteLine("-------------------------------------");
            foreach (string arg in args)
            {
                //if (Array.IndexOf(validArgs, arg) == -1) Write("!Not valid arg! "); 
                if (!validArgs.Contains(arg)) Write("!Not valid arg! ");
                WriteLine(arg);
            }

            WriteLine("-------------------------------------");


            (int v1, string v2) data;
            data.v1 = 10;
            data.v2 = "Data";

            (int v1, int v2) data2 = getValues();
            WriteLine(data2);

            int b1, b2;
            (b1, b2) = getValues();
            WriteLine($"b1={b1},b2={b2}");

            getValues(out b1, out b2);
            WriteLine($"b1={b1},b2={b2}");

            WriteLine("-------------------------------------");
            
            WriteLine("Summa=" + Summa(new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
            WriteLine("Summa=" + Summa2(10, 1, 2, 3, 4, 5, 6, 7, 8, 9));

        }

    }
}
