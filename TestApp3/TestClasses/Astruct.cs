using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace TestClasses
{
    internal struct Astruct//:Object
    {
        public const int MAX = 1000;
        
        public Astruct():this(1) { }

        public Astruct(int data) 
        { Data = data;
            WriteLine("+++ ctor struct, o:" + GetHashCode());
        }
        
        private int _data;

        public int Data
        {
            get { return _data; }
            set { if (value <= MAX) _data = value; }  
        }


        public override string ToString()
        {
            return $"Astruct: Data:{Data}, o:{GetHashCode()}";
        }
    }
}
