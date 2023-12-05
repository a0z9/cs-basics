using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace ConsoleApp1
{
    internal abstract class Box : IMovable
    {
        protected int X { get; set; }
        protected int Y { get; set; }
        public int Angle { get; protected set; }

        protected Box(int x, int y, int angle) { X = x; Y = y; Angle = angle; }
        protected Box() : this(0, 0, 0) { }

        public virtual IMovable move(int dx, int dy) {
            X += dx;
            Y += dy;
            WriteLine($"{this.GetType().Name} moves to ({X},{Y}).");
            return this;
        }
        public virtual IMovable rotate(int angle) {
            Angle += angle;
            WriteLine($"{this.GetType().Name} rotates to new angle: ({Angle}).");
            return this;
        }

        public override string ToString() =>
            $"{this.GetType().Name}: at ({X},{Y}), angle: {Angle}.";
        
    }
}
