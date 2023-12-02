using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomTest
{
    internal abstract class Sprite: IMovable
    {
        protected readonly int MAX_DX =2;
        protected readonly int MAX_DY =2;

        protected int x { get; set; } 
        protected int y { get; set; }

        public abstract int S { get; set; }

        //public void mv(int dx, int dy) {
        //    throw new Exception("!!! TODO! NOT REALIZED!!");
        //}

        public Sprite(int x, int y) { this.x = x;this.y = y; }
        public Sprite() : this(0, 0) { }

        protected virtual bool isValidDXY(int dx, int dy) { 
        if(dx<=MAX_DX && dy<=MAX_DY && dx >=-MAX_DX && dy >= -MAX_DY ) return true;
         return false;
        }

        public abstract void mv(int dx, int dy);
        public abstract void rotate(int degrees);
   
    }
}
