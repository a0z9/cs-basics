
using static System.Console;

namespace krasn23.learning
{
    public class A {
        public int data;  //field
    }

    
        //public int getData() { return _data; }
        //public void setData(int value) { _data = value; }


    class B {
        public int data;
        
    }

    internal class Prog {
        static void Main(string[] args)
        {
            WriteLine("------- CLASS TEST -------");
            A a;
            a = new A(); a.data = 123;
            WriteLine($"a object: {a.GetHashCode()}");

            B b1 = new B { data = 456 };
            B b2 = new B { data = 456 };
            WriteLine($"b1 object: {b1.GetHashCode()}");
            WriteLine($"b2 object: {b2.GetHashCode()}");
            WriteLine(b1 == b2);

            B b3 = b2, b4=b3;
            b3.data = 111;
            WriteLine($"b2.data: {b2.data}");
            WriteLine($"b3 object: {b3.GetHashCode()}");

            string s1 = "aaaa";
            string s2 = new string("aaaa");
            //---------------------------------------------------
            {
                WriteLine("-------------------");
                A1 aa1 = new A1(123);
                // aa1.PrivateMessage = "qqq";
                WriteLine(aa1.getInfo());
                aa1.Data = 3000;
                WriteLine(aa1.getInfo());
                WriteLine("Counter:" + A1.Counter);
               // for (int i = 1; i < 100_000; i++) { 
                    new A1(); new A1(); new A1(); 
                //}
                
                WriteLine("Counter:" + A1.Counter);

                WriteLine("----------------------------------------");
                B1 b11 = new B1();
                WriteLine(b11.getInfo());
                A1 b12 = new B1();
                WriteLine(b12.getInfo());


            }
            ReadKey();
        }
    }
}