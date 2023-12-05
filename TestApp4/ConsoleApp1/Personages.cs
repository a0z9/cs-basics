using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace ConsoleApp1
{
    internal class Monster:Box
    {
        public override IMovable move(int dx, int dy)
        {
            Write("Monster Move Render..."); return base.move(dx, dy);
        }

        public override IMovable rotate(int angle) {
            Write("Monster Rotate Render..."); return base.rotate(angle);
        }


    }

    class Man : Box
    {
        public override IMovable move(int dx, int dy)
        {
            Write("Man Move Render..."); return base.move(dx, dy);
        }

        public override IMovable rotate(int angle)
        {
            Write("Man Rotate Render..."); return base.rotate(angle);
        }

    }
}
