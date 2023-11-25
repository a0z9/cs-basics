using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gencollections.krasn23.learning
{
    internal class Container<T>
    {
        T Data { get; set; }

        public Container(T Data) { this.Data = Data; }

    }

    internal class Box<T> : IEnumerable
    {
        private const int BOX_SIZE = 10;
        private int size;
        private int idx;
        private T[] Data { get; set; }
       // public Box() { sizthis.Data = new T[BOX_SIZE]; }
        public Box(int size) { this.size = size;  this.Data = new T[size]; }
        public Box() : this(BOX_SIZE) { }

        public T Get(int i) => Data[i];
        public bool Add(T element) {
            if (idx < size && idx >= 0) { Data[idx] = element; idx++; return true; }
            return false;
        }

        public IEnumerator GetEnumerator()
        {
            return Data.GetEnumerator();
           // foreach (T t in Data) yield return t;
        }

        public T this[int index] { 
            get { return Data[index];}
            set { if (index < size && index >= 0) Data[index] = value; }
        }

    }

}
