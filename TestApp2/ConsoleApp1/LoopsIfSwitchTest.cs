using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using static System.Console;

namespace krasn23.a0z9.learning
{

    enum FileAccess { 
    Read=1, Write=2, Execute=4
    }

    internal class LoopsIfSwitchTest
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            WriteLine(" --------- Loop test ------------ ");

            

            Write("[");
            for (int i = 0; i < 5; ++i)
            {
                Write(i + ", ");
            }
            Write("\b\b]\n");

            {
                Write("[");
                int i = 5;
                for (; ; )
                {
                    if (i <= 0) break;
                    Write(i + ", ");
                    i--;
                }
                Write("\b\b]\n");
            }


            Write("[");
            for (int i = 0, k=10; i < 5 && k > 7; ++i, k-=2)
            {
                Write($"[{i}-{k}], ");
            }
            Write("\b\b]\n");

            int j = 3;
            do
            {
                WriteLine(j);
                ++j; 
            }
            while (j < 6);

            // ------------------

            string Flag = "w+";
            switch(Flag)
            {
                case "r+": WriteLine("choice r+!"); break;
                case "w+": WriteLine("choice w+!"); break;
                case "rw": WriteLine("choice RW!"); break;
                default: WriteLine("Bad Flag!!!"); break;
            }

            FileAccess fa = FileAccess.Read | FileAccess.Write;
            switch (fa)
            {
                case FileAccess.Read: WriteLine("choice r+!"); break;
                case FileAccess.Write: WriteLine("choice w+!"); break;
                case FileAccess.Write | FileAccess.Read: WriteLine("choice RW"); break;
                case FileAccess.Execute: WriteLine("choice Exec!"); break;

                default: WriteLine("Bad Flag!!!"); break;
            }


            ReadKey();
        }
    
    }
}
