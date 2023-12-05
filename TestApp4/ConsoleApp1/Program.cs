using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Map_1657_Path(IMovable mv)
        {
            mv.move(1, 2).rotate(369).move(-2, 5);///
            mv.jump(20, 45);
        
        }

        static void Main(string[] args)
        {
            Monster monster = new Monster(-10,3,0);
            Man man = new Man();
            WriteLine(monster); WriteLine(man);
            Map_1657_Path(monster);
            WriteLine(monster);
            //-------- ext test
            WriteLine("------------  ext test ----------- ");
            WriteLine("ext test".MyCount());
        }
    }
}
