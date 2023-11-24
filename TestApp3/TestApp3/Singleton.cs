using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace krasn23.learning
{
    internal class Singleton
    {
      private static Random seed = new Random((int)DateTime.Now.Ticks);
      private static Singleton? instance = null;
      public int Data { get; }
      private Singleton() {
            Data = seed.Next(0, 100);
            WriteLine("+++ ctor Singleton, o:" + GetHashCode());
            /* code */ }

        public static Singleton GetSingleton()
        {
            // if (instance == null) instance = new Singleton(); 
            // if (instance is null) instance = new Singleton();
            instance = instance ?? new Singleton();
            return instance;
        }

        public override string ToString()
        {
            return $"Singleton, D={Data}, Object hash:{GetHashCode()}";
        }

    }
}
