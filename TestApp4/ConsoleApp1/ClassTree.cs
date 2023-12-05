using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace ConsoleApp1
{
    internal abstract class Sprite: IMovable
    {
        protected int X { get; set; }
        protected int Y { get; set; }
        protected int Angle {  get; set; }

        protected Sprite(int x, int y, int angle) {
            X = x; Y=y; Angle=angle;
        }
        protected Sprite() : this(0, 0, 0) { }

        public virtual IMovable move(int dx, int dy) {
            X += dx;
            Y += dy;
            WriteLine($"{this.GetType().Name} moves to ({X},{Y})");
            return this;
        
        }
        public  virtual IMovable rotate(int angle) {
            Angle += angle;
            Angle %= 360;
            WriteLine($"{this.GetType().Name} rotate to ({Angle}) degrees.");
            return this;
        }

        public override string ToString() => 
            $"{this.GetType().Name} at ({X},{Y}, oriented to {Angle} degree.)";
      
    }

    internal class Monster : Sprite
    {
        public Monster(int x, int y, int angle) : base(x, y, angle) { }
        public Monster() : base() { }

        public override IMovable rotate(int angle)
        {
            Write("Rendering of Monster..: ");
            return base.rotate(angle);
        }
    }

    internal class Man : Sprite {

        public override IMovable rotate(int angle)
        {
            Write("Rendering of Man..: ");
            return base.rotate(angle);
        }

    }

}
