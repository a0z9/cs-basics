using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krasn23.a0z9.learning
{
    internal class Rectangle : Figure
    {
        protected double _a, _b;
    
        public double a { get=>_a; set => _a=value; }
        public double b { get=>_b; set => _b=value; }


        public Rectangle(double a) : this(a,a) { }
        public Rectangle(double a, double b)
        {
            _b = b;
            _a = a;
        }
        
        public Rectangle() : this(1, 1) { }
                       

        public override double S
        {
            get => _a * _b;
        }
        public override double P
        {
            get => 2 * (_a + _b);
        }

        public override string ToString() {
            return $"Rectangle: a={_a}, b={_b}, P={P}, S={S}.";
        }
    }
}
