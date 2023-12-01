using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace krasn23.a0z9.learning
{
    internal class Singleton
    {
       private static Singleton instance;

        private Singleton() {
        
        }

       public static Singleton Instance {
            //  get => instance ?? (instance = new Singleton());
            get {
                instance ??= new Singleton(); // = instance ?? new Singleton()
                return instance;
            }
        }

    }
}
