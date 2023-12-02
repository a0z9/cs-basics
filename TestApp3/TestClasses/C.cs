using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace krasn23.a0z9.learning
{

  
    internal class C : A
    {
        public C():this(1) { }  
        public C(int n) : base(n) {
            WriteLine("+++ ctor (class C) " + this);
        }

        public override void testPoly()
        {
            WriteLine("CCCC - PolyTest: --- C class -------");
        }

        public override string ToString()
        {
            return base.ToString().Replace("Class A","*Class C*");
        }

    }
}
