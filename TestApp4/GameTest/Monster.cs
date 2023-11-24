
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace game.krasn23.learning
{
    internal class Monster : Sprite
    {
        public Monster(int X, int Y, int Orient) : base(X, Y, Orient)
        {
        }

        public override void Explose()
        {
            WriteLine($"Monster Exploded!!");
        }

        public override IMovable MoveDown()
        {
            Y-=2; WriteLine($"Monster moves Down, X={X}, Y={Y}.");
            return this;
        }

        public override IMovable MoveLeft()
        {
            X-=2; WriteLine($"Monster moves Left, X={X}, Y={Y}.");
            return this;
        }

        public override IMovable MoveRight()
        {
            X+=2; WriteLine($"Monster moves Right, X={X}, Y={Y}.");
            return this;
        }

        public override IMovable MoveUp()
        {
            Y+=2; WriteLine($"Monster moves UP, X={X}, Y={Y}.");
            return this;
        }
    }
}
