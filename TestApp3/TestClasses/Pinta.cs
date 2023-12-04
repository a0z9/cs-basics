using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses
{
    class Beer {
        public override string ToString()
        {
            return "Beer " + GetHashCode();
        }
    }

    internal class Pinta
    {
        private const uint PINTA = 5;
        private static int _idx = 0;

        private Pinta() { }

        public static Beer? GetBeer
        {
            get {
                if (_idx++ < PINTA) return new Beer();
                return default;
            }
        }

       
    }
   
 }

