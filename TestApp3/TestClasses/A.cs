using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace TestClasses
{
    internal class A//:Object
    {
        public const int MAX = 1000;
        private readonly string _name;
        public string Name { get { return _name; } }
        
        public A():this(1) { }
        public A(int d) : this(d,"NoName") { }
        public A(int data, string name) 
        { Data = data;
         _name = name; 
          WriteLine("+++ ctor, o:" + GetHashCode());
        }

        private int _data;
        public int Data
        {
            get { return _data; }
            set { if (value <= MAX) _data = value; }  
        }

        public override string ToString()
        {
            return $"A: Data:{Data}, Name:{Name}, o:{GetHashCode()}";
        }

        //public int GetData() { return _data; }
        //public void SetData(int value) { _data = value; }
    }
}
