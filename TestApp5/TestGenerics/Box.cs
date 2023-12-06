using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerics
{
    internal class Box<T>
    {
        private T[] _tarr;
        public uint N {  get; private set; }
        private uint _idx = 0;
        public Box(uint N) { _tarr = new T[N]; this.N = N; }
        public Box(T[] tarr) { _tarr = tarr; this.N = (uint)tarr.Length; }

        public Box<T> Add(T element) { 
          if(_idx<N) _tarr[_idx++] = element;
          return this;
        }

        public T this[uint idx] {
            //  get => _tarr[idx];
            get { if (idx < N) return _tarr[idx]; else return default; }
            set { if(idx<N) _tarr[idx] = value; } 
        }
    }
}
