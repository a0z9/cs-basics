
using static System.Console;

namespace TestClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("-------- Class Test ---------");
            A a = new A() {Data=10 };
            a.Data = 1;
            WriteLine(a);
            WriteLine("Max data: " + A.MAX);
 
            WriteLine(new A(10));
            WriteLine(new A());
            WriteLine(new A(-1000));

            WriteLine("--------- ref-value test --------");
            Astruct astruct1 = new Astruct(10);
            WriteLine(astruct1);
            Astruct astruct2 = astruct1;
            WriteLine(astruct2); astruct2.Data = 1;
            WriteLine("---------  --------");
            WriteLine(astruct1); WriteLine(astruct2);

            WriteLine("--------- ref-value test --------");
            A aa1 = new A(10);
            WriteLine(aa1);
            A aa2 = aa1;
            WriteLine(aa2); aa2.Data = 1;
            WriteLine("---------  --------");
            WriteLine(aa1); WriteLine(aa2);




            ReadKey();
        }
    }
}
