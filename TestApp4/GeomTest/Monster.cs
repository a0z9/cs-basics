using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GeomTest
{
    internal class Monster : Sprite
    {
        protected new readonly int MAX_DX;
        protected new readonly int MAX_DY;

        public Monster(int x, int y) : base(x, y)
        {
            MAX_DX = 5; MAX_DY = 5;
        }

        public override int S { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void mv(int dx, int dy)
        {
            if (isValidDXY(dx, dy))
            {
                x += dx; y += dy;
                WriteLine($"Move M0nster to ({x},{y}); Render monster image....");
            }
           else WriteLine($"M0nster stay at ({x},{y}); No Render....");
        }

        protected override bool isValidDXY(int dx, int dy)
        {
            if (dx <= MAX_DX && dy <= MAX_DY && dx >= -MAX_DX && dy >= -MAX_DY) return true;
            return false;
        }

        public override void rotate(int degrees)
        {
            WriteLine($"Rotate M0nster at {degrees}");
        }
    }
}
