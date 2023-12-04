using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationDelegateEvents
{
    internal class Wire
    {
        public int Length { get; set; }
        public int CrossIndex {  get; set; }
        public Wire(int length, int crossIndex) { Length = length; CrossIndex = crossIndex; }
        public Wire() : this(10, 5) { }

        public override string ToString() {
            return $"Wire L:{Length}, Idx:{CrossIndex}";
        }

        private static bool ifIndexSame(Wire? w1, Wire? w2)
        { return w1?.CrossIndex == w2?.CrossIndex; }

        public static bool operator == (Wire? w1, Wire? w2)
        {
            return (w1?.Length == w2?.Length) && (w1?.CrossIndex == w2?.CrossIndex); 
        }

        public static bool operator !=(Wire w1, Wire w2)
        {
            return (w1.Length != w2.Length) || (w1.CrossIndex != w2.CrossIndex);
        }

        public override bool Equals(object? o)
        {
            Wire? w2 = o as Wire;
            if (w2 is null) return false;

            return  (Length == w2?.Length) && 
                (CrossIndex == w2?.CrossIndex);
        }

        public static Wire? operator +(Wire w1, Wire w2) {
            if (ifIndexSame(w1, w2)) { 
                Wire w3 = new Wire(w1.Length + w2.Length, w1.CrossIndex);
               // w1 = w2 = null;
                return w3; }
            else return null;
        }

        public static Wire? Join(ref Wire? w1, ref Wire? w2)
        {
            if (w1 is null || w2 is null) return null;
            if (ifIndexSame(w1, w2))
            {
                Wire w3 = new Wire(w1.Length + w2.Length, w1.CrossIndex);
                w1 = w2 = null;
                return w3;
            }
            else return null;
        }

    }
}
