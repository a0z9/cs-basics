
using static System.Console;

namespace krasn23.learning
{
       
        internal class RefCast {

        static void TrySwap(int a, int b)
        {
            int c = a; a = b; b = c;
        }

        static void TrySwap2(ref int a, ref int b)
        {
            int c = a; a = b; b = c;
        }

        static void Swap<T>(ref T? a, ref T? b)
        {
            T? c = a; a = b; b = c;
        }


        static void Main(string[] args)
        {
            int a = 77, b = 11;
            WriteLine($"a={a}, b={b}");
            TrySwap(a, b);
            WriteLine($"a={a}, b={b}");
            TrySwap2(ref a, ref b);
            WriteLine($"a={a}, b={b}");

            //---------------------------------
            Pinta? p1 = Pinta.GetBeer();
            Pinta? p2 = Pinta.GetBeer();
            WriteLine($"p1={p1}, p2={p2}");
            Swap<Pinta>(ref p1, ref p2);
            WriteLine($"p1={p1}, p2={p2}");

            ReadKey();
        }
    }
}