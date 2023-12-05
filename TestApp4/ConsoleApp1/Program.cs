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
        static void MoveCastleLevel1Path(IMovable mv) {
            mv.move(1, 1).rotate(25).
               move(-10, 2).
               move(2, 3);
        
        }

        static void Main(string[] args)
        {
         Monster monster = new Monster();
            WriteLine(monster);
            MoveCastleLevel1Path(monster);
            WriteLine(monster);


        }
    }
}
