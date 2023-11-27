using System.Xml.Linq;
using static System.Console;

namespace krasn23.a0z9.learning
{
    public delegate void GreetsHandler(string name, int importance);

    internal class DelegateTest
    {
        public delegate void GreetsHandler(string name, int importance);

        static void SayHello(string name, int importance){
            WriteLine($"Hello, {name} {new String('!', importance)}. ");
        }

        static void SayHi(string name, int importance) => WriteLine($"Hi, {name} {new String('!', importance)}. ");

        static void SaySalute(string name, int importance)
        {
            WriteLine($"Салют, {name} {new String('!', importance)}. ");
        }

        static void testGreets(GreetsHandler greets, string name, int n)
        {
            greets(name, n);
        }

        static GreetsHandler getGreets(string greets)
        { 
          switch(greets) {
                case "hi": return SayHi;
                case "he": return SayHello;
                case "sa": return SaySalute;
                default: return null;
            }

        }

        static void testGreets(Action<string,int> greets, string name, int n)
        {
            greets(name, n);
        }

        static void Main1(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
           
            Console.WriteLine("---- Delegates ----- ");
            GreetsHandler gs = SayHello;
            gs += SayHi;
            gs += SaySalute;
            gs("Andrei", 1);
            WriteLine("-------------------------------");
            gs -= SayHi;
            gs("Andrei", 2);
            WriteLine("-------------------------------");
            testGreets(getGreets("sa"), "Basil", 3);
            WriteLine("+++++---------------------------");
            Action<string,int> agreets =
                (name,importance) => WriteLine($"Hi, {name} {new String('!', importance)}. ");

            //---------- Dictionary for calc -------------------

            Dictionary<string, Func<double, double, double>> calcDict =
                new Dictionary<string, Func<double, double, double>>()
                {
                    {"+", (a,b)=>a+b },
                    {"-", (a,b)=>a-b },
                    {"*", (a,b)=>a*b },
                    {"/", (a,b)=>a/b },
                    {"%", (a,b)=>100*a/b }
                    //.....
                };
            // Задание: Интерировать calcDict в программу калькулятор: 
            // https://github.com/a0z9/cs-basics/blob/master/class-work/solutions/Answers/Answers/Calculus.cs

            WriteLine($"{calcDict["+"](2.3, 3.4):N5}");

            // Library test ---
            Library lib = new Library();
            lib.addBook(new Book() { Author = "Tolstoi A.", Title = "Aelita" });


            Library.NewBookHandler h1 = mess => WriteLine("S1: " + mess);
            Library.NewBookHandler h2 = mess => WriteLine("S2: " + mess);

            lib.NewBook += h1;
            lib.addBook(new Book() { Author = "London J.", Title = "White Silence" });
            lib.addBook(new Book() { Author = "Tolstoi A.", Title = "Aelita2" });

            lib.NewBook -= h1;
            lib.NewBook += h2;

            lib.addBook(new Book() { Author = "London J.", Title = "White Silence2" });

        }
       
    }
}
