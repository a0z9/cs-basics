
using static System.Console;

namespace krasn23.learning
{

        internal class Prog2 {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetSingleton();
            Singleton s2 = Singleton.GetSingleton();
            Singleton s3 = Singleton.GetSingleton();

            WriteLine(s1);
            WriteLine(s2);
            WriteLine(s3);

            //----------------------------------
            Pinta? p1 = Pinta.GetBeer();
            Pinta? p2 = Pinta.GetBeer();
            Pinta? p3 = Pinta.GetBeer();
            Pinta? p4 = Pinta.GetBeer();

            WriteLine(p1);
            WriteLine(p2);
            WriteLine(p3);
            WriteLine(p4);



            ReadKey();
        }
    }
}