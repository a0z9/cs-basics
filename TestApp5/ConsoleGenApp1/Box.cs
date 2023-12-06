using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGenApp1
{
    internal class Box<T> : IEnumerable
    {
        private T[] _arr;
        private uint _N;
        public uint N {  get => _N; private set => _N=value; }
        private uint _idx;

        public Box(uint N) { _arr = new T[N]; this.N = N; }
        public Box(T[] arr) { _arr = arr; N = (uint)arr.Length; _idx = N; }

        public Box<T> Add(T element)
        {
            //if (_idx >= N) ExposeArray(N * 2);
            if (_idx >= N) ExposeArray2(ref _arr, N*2, out _N);
            _arr[_idx++] = element;
            return this;
        }

        private bool ExposeArray(uint N_new)
        { 
            if (N_new > N) { 
                T[] _arr2 = new T[N_new];
                Array.Copy(_arr, _arr2, N);
                N = N_new;
                _arr = _arr2;
                return true; }

            return false;
        }

         private static uint ExposeArray2(ref T[] arr,uint N_new, out uint N)
        {
            N = (uint)arr.Length;
           
            if (N_new > N)
            {
                T[] _arr2 = new T[N_new];
                Array.Copy(arr, _arr2, N);
                arr = _arr2;
                N = N_new;
                return N_new;
            }
            return N;
           
        }

        public IEnumerator GetEnumerator()
        {
           return _arr.GetEnumerator();
        }

        public T this[uint idx] 
        {  get { return _arr[idx]; }
          // get { if (idx < N) return _arr[idx]; else return default; }
           set { if(idx<N) _arr[idx] = value;} 
        }


    }
}
