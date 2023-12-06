using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace ConsoleGenApp1
{
    internal class Program
    {
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



        }
    }
}
