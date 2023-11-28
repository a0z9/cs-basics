using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        static void Main(string[] args)
        {
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


            ReadKey();
        }
    }
}
