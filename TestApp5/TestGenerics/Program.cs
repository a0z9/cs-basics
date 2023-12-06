using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TestException;
using static System.Console;

namespace TestGenerics
{
    internal class Program
    {
        static void Swap2(ref int a, ref int b) {
            int c = a; a = b; b = c;
        }
        static void Swap<T>(ref T a, ref T b)
        {
            T c = a; a = b; b = c;
        }

        static void Main(string[] args)
        {
            int a = 100, b = -777;
            WriteLine($"a:{a}, b:{b};");
            Swap<int>(ref a, ref b);
            WriteLine($"a:{a}, b:{b};");

            WriteLine("---------- Account Swap Test ----------");

            Account acc1 = new Account(deposit: 111);
            Account acc2 = new Account(deposit: 222);

            WriteLine($"{acc1}, {acc2};");
            Swap(ref acc1, ref acc2);
            WriteLine($"{acc1}, {acc2};");
            WriteLine("---------- Generic Type Test ----------");

            Box<string> box = new Box<string>(3);
            box.Add("AAA").Add("BBB").Add("CCC").Add("DDD");
            for (uint i = 0; i < 5; i++) WriteLine("--> " + box[i] + " <--");






        }
    }
}
