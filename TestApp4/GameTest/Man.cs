

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace game.krasn23.learning
{
    internal class Man : Sprite
    {
        public Man(int X, int Y, int Orient) : base(X, Y, Orient)
        {
        }

        public override void Explose()
        {
            WriteLine($"Man Exploded!!");
        }

        public override IMovable MoveDown()
        {
            Y--; WriteLine($"Man moves Down, X={X}, Y={Y}.");
            return this;
        }

        public override IMovable MoveLeft()
        {
            X--; WriteLine($"Man moves Left, X={X}, Y={Y}.");
            return this;
        }

        public override IMovable MoveRight()
        {
            X++; WriteLine($"Man moves Right, X={X}, Y={Y}.");
            return this;
        }

        public override IMovable MoveUp()
        {
            Y++; WriteLine($"Man moves UP, X={X}, Y={Y}.");
            return this;
        }
    }
}
