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

        enum FileAcces
        {
           Read=1,     //0b0001
           Write=2,    //0b0010
           Execute=4,  //0b0100
           Append=8    //0b1000
        }

        static void Main(string[] args)
        {
            int i1 = 3;

            if (i1 == 30 )
            {

            }
            else { 
            
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
            WriteLine($"Class has {N} student" + ((N!=1)?"s.":"."));

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

    }
}
