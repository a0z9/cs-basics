using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.krasn23.learning
{
    internal interface IMovable
    {
        IMovable MoveLeft();
        IMovable MoveRight();
        IMovable MoveUp();
        IMovable MoveDown();
    }
}
