using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace krasn23.a0z9.learning
{
    internal class D : A
    {
        public D():this(1) { }  
        public D(int n) : base(n) {
            WriteLine("+++ ctor (class D) " + this);
        }

        public override void testPoly()
        {
            WriteLine("DDDD - PolyTest: --- D class -------");
        }

        public void testD() {
            WriteLine("!!! Test D!");
        }

        public override string ToString()
        {
            return base.ToString().Replace("Class A","*Class D*");
        }

    }
}
