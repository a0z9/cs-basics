using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krasn23.a0z9.learning
{
    internal class Coords2D
    {
        public int x { get; set; }
        public int y { get; set; }  
        public Coords2D(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public override string ToString() => $"({x},{y})";
    }
}
