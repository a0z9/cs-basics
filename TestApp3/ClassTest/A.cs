using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace krasn23.a0z9.learning
{
    internal class A
    {
        private int data;

        public int Data
        {
            get { return data; }
            set { 
                if(value >=0)
                data = value; }
        }


        public int GetData () => data;
        public void SetData(int value) =>  data = value;

        public A(int data) {
            Data = data;
            WriteLine("+++ ctor of A type, o:" + GetHashCode());
        }

        public A() : this(0) { }

        public override string ToString()
        {
            return $"Class A, data={data}, ref={GetHashCode()}.";
        }
    }
}
