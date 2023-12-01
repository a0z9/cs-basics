using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace krasn23.a0z9.learning
{
    internal struct B
    {
        public int data;



        public override string ToString()
        {
            return $"Struct B, data:{data,5}, object:{GetHashCode()}";
        }

    }
}
