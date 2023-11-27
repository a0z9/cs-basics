using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace krasn23.a0z9.learning
{
    internal class Circle : Ellipse
    {
        public new double a { get => _a; set => _a = _b = value; }
        public new double b { get => _b; set => _a = _b = value; }

        public Circle(double a):base(a) { }
        public Circle() : base() { }

        private Circle(double a, double b) { }

        public override string ToString()
        {
            return $"Circle:    R={a}, P={P:N5}, S={S:N5}.";
        }


    }
}
