
using static System.Console;

namespace krasn23.a0z9.learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("---------- Test Classes -----------");
            //A a = new A() { Data = 111 };
            A a = new A(111);
            WriteLine("A Counter=" + A.Counter);
            //a.Data = 1234;
            A a2 = a; a2.Data = 11;

            WriteLine(a);
            WriteLine(new A(100));
            WriteLine(new A());
            WriteLine("MIN_DATA=" + A.MIN_DATA);
            WriteLine("A Counter=" + A.Counter);


            WriteLine("---------- Test Structs -----------");
            B b = new B(); b.data = 111;
            WriteLine(b);
            B b2 = b; b2.data = 222;
            WriteLine(b); WriteLine(b2);

            WriteLine("---------- Connection Test -----------");
            Connection con1 = new Connection("192.168.33.2", 36177);
            new Connection("192.11.22.33", 367);
            new Connection();
            new Connection(1414);

            WriteLine("---------- Inheritance Test -----------");
            C c = new C();
            C c2 = new C(11);

            A c3 = new C(7);
            c3.testPoly();

            ReadKey();
        }
    }
}
