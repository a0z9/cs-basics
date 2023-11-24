
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.krasn23.learning
{
    internal abstract class Sprite: IMovable
    {
      protected int X {get; set;}
      protected int Y { get; set;}

       protected int Orient { get; set;}

        public Sprite(int X, int Y, int Orient)
        {
            this.X = X;
            this.Y = Y;
            this.Orient = Orient;
        }
      
     
        public abstract void Explose();
        public abstract IMovable MoveLeft();
        public abstract IMovable MoveRight();
        public abstract IMovable MoveUp();
        public abstract IMovable MoveDown();
    }
}
