
using static System.Console;

namespace krasn23.a0z9.learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("-------- class test ----------");
            A a = new A();
            a.Data = 123;
            WriteLine(a);

            A b = a; b.Data = 7771111;
            WriteLine(a);

            WriteLine(new A(10));
            WriteLine(new A(10,Status.TopSecret));
            WriteLine(new A());


            ReadKey();
        }
    }
}
