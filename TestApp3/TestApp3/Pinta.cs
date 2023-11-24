using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace krasn23.learning
{
    internal class Pinta
    {
      private static Random seed = new Random((int)DateTime.Now.Ticks);
      private const int NUM = 3;
      private static Pinta[] instance = new Pinta[NUM];
        private static int counter = 0;

      public int Data { get; }
      private Pinta() {
            Data = seed.Next(500, 1000);
            WriteLine("+++ ctor Pinta, o:" + GetHashCode());
                    }

        public static Pinta? GetBeer()
        {
            if (counter < NUM) { instance[counter] = new Pinta(); counter++; }
            else return null;
      
            return instance[counter-1];
        }
        public override string ToString()
        {
            return $"Pinta, D={Data}, Object hash:{GetHashCode()}";
        }

    }
}
