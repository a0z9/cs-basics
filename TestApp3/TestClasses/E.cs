using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace krasn23.a0z9.learning
{
    internal class E
    {
        public const int MIN_DATA = 10;
        private int data = 1;

        public E():this(1) { }  
        public E(int n) {
            WriteLine("+++ ctor (class E) " + this);
        }

        public void testPoly()
        {
            WriteLine("EEEE - PolyTest: --- E class -------");
        }

        public int Data
        {
            get { return data; }
            set
            {
                if (value >= MIN_DATA)
                    data = value;
            }
        }

        public void testE() {
            WriteLine("!!! Test E!");
        }

        public override string ToString()
        {
            return $"Class E, data:{data,5}, object:{GetHashCode()}";
        }

    }
}
