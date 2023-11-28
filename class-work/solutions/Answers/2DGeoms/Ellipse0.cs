using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krasn23.a0z9.learning
{
    internal class Ellipse0 : Figure
    {
        public double a { get; set; }
        public double b { get; set; }

        public Ellipse0(double a) : this(a,a) { }
        public Ellipse0(double a, double b)
        {
            this.b = b;
            this.a = a;
        }
        
        public Ellipse0() : this(1, 1) { }

        public override double S
        {
            get => Math.PI * a * b;
        }
        public override double P
        {
            get => Math.PI * (a + b);
        }

        public override string ToString() {
            return $"Ellipse0: a={a}, b={b}, P={P}, S={S}.";
        }
    }
}
