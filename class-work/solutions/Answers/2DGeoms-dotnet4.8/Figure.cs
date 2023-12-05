using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krasn23.a0z9.learning
{
     abstract class Figure
    {
        public Coords2D Coords {  get; set; }

        public abstract double S { get; }
        public abstract double P { get; }

        
    }
}
