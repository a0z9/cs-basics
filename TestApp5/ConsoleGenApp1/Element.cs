using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGenApp1
{
    internal class Element1
    {
        public Type type { get; private set; }
        public object Data { get; set; }

        public Element1(object o) {
            Data = o;
            type = o.GetType();
        }

    }

    internal class Element<T>
    {
        
        public T Data { get; set; }

        public Element(T o)
        {
            Data = o;
        }

    }

}
