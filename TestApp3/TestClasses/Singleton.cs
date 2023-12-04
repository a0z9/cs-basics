using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses
{
    internal class Singleton
    {
        private static Singleton? instance;

        private Singleton() { }
        public override string ToString() => "Singleton: " + GetHashCode();

        public static Singleton Instance
        {
            get {
                //if (instance is null) instance = new Singleton();
                //instance = instance ?? new Singleton();
                instance ??= new Singleton();
                return instance; }
        }
        public static Singleton GetInstance() {
            instance ??= new Singleton();
            return instance;
        }
    }
   
 }
