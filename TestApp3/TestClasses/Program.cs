
using static System.Console;

namespace TestClasses
{
    internal class Program
    {
        static void BasiClassTest() {
            WriteLine("-------- Class Test ---------");
            A a = new A() { Data = 10 };
            a.Data = 1;
            WriteLine(a);
            WriteLine("Max data: " + A.MAX + ", Couneter:" + A.Counter);

            WriteLine(new A(10));
            WriteLine(new A());
            WriteLine(new A(-1000));
            WriteLine("Couneter:" + A.Counter);

            WriteLine("--------- ref-value test (Structs) --------");
            Astruct astruct1 = new Astruct(10);
            WriteLine(astruct1);
            Astruct astruct2 = astruct1;
            WriteLine(astruct2); astruct2.Data = 1;
            WriteLine("---------  --------");
            WriteLine(astruct1); WriteLine(astruct2);

            WriteLine("--------- ref-value test (Classes) --------");
            A aa1 = new A(10);
            WriteLine(aa1);
            A aa2 = aa1;
            WriteLine(aa2); aa2.Data = 1;
            WriteLine("---------  --------");
            WriteLine(aa1); WriteLine(aa2);
            WriteLine("Couneter:" + A.Counter);
        }

        static void Main(string[] args)
        {
            // BasiClassTest();

            WriteLine("--------- Inheritance test --------");


            B b1 = new B(100, "Basilic");
            B b2 = new B(100);
            WriteLine("Counter:" + B.Counter);
            WriteLine(b1);

            A b3 = (A) new B(7, "Pete");
            B b4 = new B();
            A a1 = b4;
            A a2 = new A();

           // b4 = (B)a2;

            Object o = a2;

            WriteLine(o.GetType());
            WriteLine(b3);
            //WriteLine(((B)o).Data); 
            WriteLine((o as B)?.Data);

            if (o.GetType() == typeof(B)) WriteLine(((B)o).Data);
            WriteLine("---------- poli test ---------- ");

            A ab = new B();
            ab.mv();
            Mover(new A());
            Mover(new B());




            ReadKey();
        }
        static void Mover(Imv mv) {
            mv.mv();
            mv.mv();
        }
        
    }
}
