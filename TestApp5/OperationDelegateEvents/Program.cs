using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OperationDelegateEvents
{
    public delegate void GreetsHandler(string name);

    internal class Program
    {
        static void genTest() {
            Console.WriteLine("--- ops test ---");
            Wire? w1 = new Wire();
            Wire? w2 = new Wire();
            Wire? w3 = w1 + w2;

            WriteLine(w1 == w2);
            WriteLine(w1.Equals(w2));

            WriteLine($"{w1}\n{w2}\n{w3}");

            Wire? w4 = Wire.Join(ref w1, ref w3);
            WriteLine((w1 is not null) ? w1 : "Empty!!");
            //  WriteLine( w1 ?? "Empty");
            WriteLine((w3 is not null) ? w3 : "Empty!!");
            WriteLine((w4 is not null) ? w4 : "Empty!!");

            // w1 = w2 = null;
            WriteLine("-----------------------------------");
            Box<Wire> b1 = new Box<Wire>(5);

            b1.NewElement += mess => WriteLine(mess);

            b1.Add(new Wire());
            b1.Add(new Wire(12, 2));
            b1.Add(new Wire(1, 50));
            b1[3] = new Wire(2, 3);
            b1.Add(new Wire());
            b1.Add(new Wire(22, 22));
            b1.Add(new Wire(33, 333));
            for (uint i = 0; i < b1.Length; i++) WriteLine(b1[i]);

        }
        static void SayHello(string nm)=> WriteLine($"Hello, {nm}!!");
        static void SayHi(string nm) => WriteLine($"Hi, {nm}!!");
        static void SayPrivet(string nm) => WriteLine($"Privet, {nm}!!");

        static void TestDelegate(GreetsHandler gs, string n)
        {
            gs(n);
        }

        static void Main(string[] args)
        {
            genTest();
            WriteLine("---------- Delegates test --------------");
            GreetsHandler gs = SayHello;
            gs += SayPrivet;
            gs += SayPrivet;
            gs += SayHi;
           
            gs("Andrei");
            WriteLine("---------------------------------");
            gs -= SayPrivet;
            gs -= SayHello;
            gs += (string n) => WriteLine($"Салют,{n}!!!");
            TestDelegate(gs, "Андрей");
            TestDelegate((string s) => WriteLine($"Salute,{s}"), "Андрей");


            Action<string> act = SayHi;
            act("Andre");



            ReadKey();
            
        }
    }
}
