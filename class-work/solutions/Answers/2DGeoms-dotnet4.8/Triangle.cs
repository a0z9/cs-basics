using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krasn23.a0z9.learning
{
    internal class Triangle : Rectangle
    {
        
        public Triangle(double a) : this(a,a) { }
        public Triangle(double a, double b):base(a,b) { }
        public Triangle() : this(1, 1) { }
                      

        public override double S 
        {
            get => base.S/2;
        }
        public override double P
        {
            get => base.P/2;
        }
    }
}
