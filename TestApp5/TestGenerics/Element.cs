using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestException;

namespace TestGenerics
{
    internal class Element<T>// where T:Account 
    {
        public T Value { get; private set; }    
        public Element(T Value) {  this.Value = Value; }


    }
}
