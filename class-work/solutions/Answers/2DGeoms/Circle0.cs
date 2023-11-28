using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace krasn23.a0z9.learning
{
    internal class Circle0 : Ellipse0
    {
        public new double a { get => base.a; set { base.a = base.b = value; } }
        public new double b { get => base.b; set { base.b = base.a = value; } }

        public Circle0(double a):base(a) { }
        public Circle0() : base() { }

        private Circle0(double a, double b) { }

        public override string ToString()
        {
            return $"Circle0: R={a}, P={P}, S={S}.";
        }


    }
}
