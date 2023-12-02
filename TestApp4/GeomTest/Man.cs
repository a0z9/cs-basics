using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace GeomTest
{
    internal class Man : Sprite
    {
        

        public Man(int x, int y) : base(x, y)
        {
       
        }

        public override int S { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void mv(int dx, int dy)
        {
            if (isValidDXY(dx, dy)) { 
                x += dx; y += dy;
                WriteLine($"Move man to ({x},{y}); Render image....");
            }
            else WriteLine($"Man stay at ({x},{y}); No Render....");
        }

        public override void rotate(int degrees)
        {
            WriteLine($"Rotate MAn at {degrees}");
        }

     
    }
}
