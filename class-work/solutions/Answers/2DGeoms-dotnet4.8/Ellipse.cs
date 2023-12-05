using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krasn23.a0z9.learning
{
    internal class Ellipse : Figure2dim
    {

        public Ellipse(double a) : this(a,a) { }
        public Ellipse(double a, double b):base(a,b) { }
        public Ellipse(double a, double b,Point2D coords) : base(a, b, coords) { }
        public Ellipse() : this(1, 1) { }

        public override double S
        {
            get => Math.PI * _a * _b;
        }
        public override double P
        {
            get => Math.PI * (_a + _b);
        }

     /*   public override string ToString() {
            return $"Ellipse:   a={_a}, b={_b}, P={P:N5}, S={S:N5}.";
        }*/
    }
}
