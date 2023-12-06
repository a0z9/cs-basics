using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace ConsoleGenApp1
{
    internal class Program
    {
        static double Summa<T>(T[] arr) //where T : class
        { double s = 0;
            foreach (object o in arr) s += Convert.ToDouble(o);
          return s;
        }


        static double Summa2(params object[] arr) //where T : class
        {
            double s = 0;
            foreach (object o in arr) s += Convert.ToDouble(o);
            return s;
        }

        static void Main(string[] args)
        {
            Element1 el = new Element1("aaa");
            if (el.type == typeof(string)) el.Data = el.Data + "bbb";
            WriteLine(el.Data);
            //el.Data = Convert.ToInt32(el.Data) + "bbb";

            Element<int> el2 = new Element<int>(12);
            Element1 el3 = new Element1(10);
            WriteLine(el3.Data.GetType());
            el2.Data = 1222;

            Box<int> box1 = new Box<int>(3);
            Box<string> box2 = new Box<string>(new string[] {"aa","bb","cc"});
            for (uint i = 0; i < box2.N; i++) WriteLine(box2[i]);
            box1.Add(111).Add(222).Add(333);
            WriteLine("N=" + box1.N);
            box1.Add(444).Add(555);
            WriteLine("N=" + box1.N);
            foreach (var v in box1) Write(v + ",");
            WriteLine("\b");

            for (uint i = 0; i < box1.N; i++) WriteLine(box1[i]);
            foreach(var v in box2) WriteLine(v);
            WriteLine("Summa1=" + Summa<int>(new int[] { 1, 2, 3, 4, 5 }));
            WriteLine("Summa2=" + Summa<long>(new long[] { 1, 2, 3, 4, 5 }));
            WriteLine("Summa3=" + Summa2(1, 2, 3, 4, 5 ));

            int[] arr = new int[] {-1,4,2,-6,22,3, -6 };
            WriteLine($"[{String.Join(",",arr)}]");
            Array.Sort(arr, (a, b) => b - a);
            WriteLine($"[{String.Join(",", arr)}]");



        }
    }
}
