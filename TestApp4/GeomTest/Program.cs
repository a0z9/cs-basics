using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace GeomTest
{
    internal class Program
    {

        static bool PassCastleLevel2(IMovable box)
        {
            //Follow map ...
            box.mv(2, 2);
            box.mv(3, -3);
            box.mv(1, -1);
            box.mv(4, -3);
            box.rotate(20);
            box.mv(1, -1);
            ///
            return true;
        }

        static void Main(string[] args)
        {
            Man man = new Man(1, 20);
           
            Monster monter = new Monster(10, 20);

            WriteLine("---------- MAn move -------- ");
            PassCastleLevel2(man);

            WriteLine("---------- Monster move -------- ");
            PassCastleLevel2(monter);


        }
    }
}
