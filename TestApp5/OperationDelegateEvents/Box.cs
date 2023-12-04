using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationDelegateEvents
{
    internal class Box<T>
    {
        private T[] arr;
        public int Length { get; private set; }
        private uint idx;
        public Box(int N)
        {
            Length = N;
            arr = new T[N];
        }

        private bool isIndexValid(uint index) {  return index < Length; }

        public Box(T[] arr)
        {
            this.arr = arr;
        }

        public bool Add(T item)
        {
            if (idx < Length) { arr[idx++] = item; return true; }
            return false;
        }

        public T? this[uint index]
        {
            get { if (isIndexValid(index)) { return arr[index]; } return default(T);  }
            set { if (isIndexValid(index)) arr[index] = value; }
        }

    }
}
