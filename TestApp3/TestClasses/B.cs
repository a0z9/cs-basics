using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace TestClasses
{
    internal class B:A
    {
        static B()
        {
            // todo....
            WriteLine("+++ static ctor of B!");

        }
        public override void Run() { WriteLine("B run"); }

        public override void mv()
        {
            WriteLine("B moves..");
        }

        public B() : base() { }
        public B(int data):base(data) { }
        public B(int data, string  name) : base(data, name) { }

        public override string ToString()
        {
            return base.ToString().Replace("A","B");
        }

    }
}
