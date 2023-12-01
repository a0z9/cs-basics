using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace krasn23.a0z9.learning
{
    enum Status { 
    Important, Some, SoSo, Confidential, TopSecret //,.....
    }

    internal class A
    {
        private int data;

        public Status Stat { get; private set; }  

        public int Data
        {
            get { return data; }
            set { 
                if(value >=0)
                data = value; }
        }


        public int GetData () => data;
        public void SetData(int value) =>  data = value;

        public A(int data, Status status) {
            Data = data;
            Stat = status;
            WriteLine("+++ ctor of A type, o:" + GetHashCode());
        }

        public A() : this(0,Status.Some) { }
        public A(int data) : this(data, Status.Some) { }

        public override string ToString()
        {
            return $"Class A, data={data}, status={Stat} ref={GetHashCode()}.";
        }
    }
}
