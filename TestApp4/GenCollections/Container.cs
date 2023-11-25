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
   }
