using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGenApp1
{
    internal class Box<T>
    {
        private T[] _arr;
        public uint N {  get; private set; }
        private uint _idx;

        public Box(uint N) { _arr = new T[N]; this.N = N; }
        public Box(T[] arr) { _arr = arr; N = (uint)arr.Length; }

        public T this[uint idx] 
        {  get { return _arr[idx]; }
          // get { if (idx < N) return _arr[idx]; else return default; }
           set { if(idx<N) _arr[idx] = value;} 
        }


    }
}
