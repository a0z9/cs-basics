using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krasn23.a0z9.learning
{
    internal abstract class Figure2dim : Figure
    {
        protected double _a, _b;

        public double a { get => _a; set => _a = value; }
        public double b { get => _b; set => _b = value; }

        public Figure2dim(double a) : this(a, a) { }
        public Figure2dim(double a, double b) : this(a, b, new Coords2D(0, 0)) { }
        public Figure2dim(double a, double b, Coords2D Coords)
        {
            this.Coords = Coords;
            _b = b;
            _a = a;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} at point: {Coords}, a={a}, b={b}, P={P:N5}, S={S:N5}.";
        }

    }
}
