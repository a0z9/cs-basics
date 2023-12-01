using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace krasn23.a0z9.learning
{
   
    internal class A:Object
    {
        public const int MIN_DATA = 10;
        private int data = 1;
        private static int counter;

        public static int Counter { get => counter; }

        static A() {
            WriteLine("+++ static ctor");
            counter = 0;
        }

        public virtual void testPoly() {

            WriteLine("AAAA - PolyTest: --- A class -------");
        }

        public int Data {  
            get { return data; } 
            set { 
                if(value >=MIN_DATA)
                data = value; }
        }

        public A():this(1) { }
        public A(int data) { Data = data; WriteLine("+++ ctor (class A)" + this); counter++; }

       // public int GetData() => data;
       // public void SetData(int value) => data = value;

        public override string ToString()
        {
            return $"Class A, data:{data,5}, object:{GetHashCode()}";
        }
    }
}
