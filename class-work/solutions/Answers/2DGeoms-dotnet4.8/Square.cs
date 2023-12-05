using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace krasn23.a0z9.learning
{
    internal class Square : Rectangle
    {
        public new double a { get => _a; set => _a = _b = value; }
        public new double b { get => _b; set => _a = _b = value; }

        public Square(double a):base(a) { }
        public Square() : base() { }

        private Square(double a, double b) { }
    }
}
