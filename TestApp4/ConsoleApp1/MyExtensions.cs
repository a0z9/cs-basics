using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal static class MyExtensions
    {
        public static IMovable jump(this IMovable mv, int j, int angle) {
            //Sprite s = mv as Sprite;
            int dx = (int)(j * Math.Sin(angle*Math.PI/180));
            int dy = (int)(j * Math.Cos(angle * Math.PI /180));
            Write($"Jump at {j} to angle {angle}..");
            return mv.rotate(angle).move(dx, dy);
       
        }

    }
}
