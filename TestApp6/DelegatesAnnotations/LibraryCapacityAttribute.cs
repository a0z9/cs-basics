using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krasn23.a0z9.learning
{
    enum LibCapacity
    { 
     Tiny,Small,Medium,Huge
    }


    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    internal class LibraryCapacityAttribute:Attribute
    {
        private LibCapacity value = LibCapacity.Medium;
        public LibCapacity Capacity { get => value; }
        public LibraryCapacityAttribute(LibCapacity capacity) {
            value = capacity;
        }

        public LibraryCapacityAttribute() { }


    }
}
