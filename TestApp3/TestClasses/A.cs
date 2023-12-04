using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace TestClasses
{
    abstract class A0 { 
    
        public abstract void Run();
    }

    internal class A: A0, Imv
    {
        private static ulong _counter = 0;
        public static ulong Counter => _counter;

        public override void Run() { WriteLine("A run"); }

        static A() {
            // todo....
            WriteLine("+++ static ctor of A!");

        }

        public virtual void mv() {
            WriteLine("A moves..");
        }

        public const int MAX = 1000;
        private readonly string _name;
        public string Name { get { return _name; } }
        
        public A():this(1) { }
        public A(int d) : this(d,"NoName") { }
        public A(int data, string name) 
        { Data = data;
         _name = name; 
          WriteLine("+++ ctor, o:" + GetHashCode());
         _counter++;
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
