using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using static System.Console;

namespace gencollections.krasn23.learning
{
    internal class Program
    {
        static void printCollection(IEnumerable col)
        {
            Write("{"); foreach (var d in col) Write(d + ", ");
            WriteLine("\b\b}");
        }

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            Box<int> box = new Box<int>(3);
            box.Add(100);
            box.Add(3000);
            box.Add(-300);
            box.Add(-440);

            printCollection(box);
            //--- Coll test
            ArrayList alist1 = new ArrayList(10) { 1, 2, new Box<double>(), "Hello!" };
            printCollection(alist1);
            ArrayList alist2 = new ArrayList(10) { 1.3, 2.0, -20.0, 4.0, 32.6, -11.0, 5.0, 6.0, 99.0 };
            alist2.Add(-32.1);
            alist2.Add(44.2);
            alist2.RemoveAt(2);

            printCollection(alist2);

            //--- LINQ ---
            var res = from double d in alist2
                      where d >4
                      orderby d descending
                      select d;

            printCollection(res);
            alist2.Sort(new MyComp());
            
            printCollection(alist2);

            // Array sort
            WriteLine("----- Array sort --- ");
            int[] arr = new[] { -22, 1, 2, 55, -4, -66, 3, 77, 2 };
            printCollection(arr);
            Array.Sort(arr, (a, b) => b - a);
            printCollection(arr);


            // List
            WriteLine("----- List sort --- ");
            List<string> inventory = new List<string>
            { "AA21657", "BC1763876", "CD2766", "YY7264867"};
            inventory.Add("DG751276");

            printCollection(inventory);
            inventory.Sort((x, y) => x.Length - y.Length);
            printCollection(inventory);

            LinkedList<string> list = new LinkedList<string>();


            // Stack, Queue



            // Dictionary
            Dictionary<int, string> dict =
                new Dictionary<int, string> {
                    {1,"Hello!" },
                    { -10, "Hi!"},
                    { 2, "HowdoUdo!!"}
                };
            dict.Add(7, "Salute!!");
            dict[7] = "!!Salute!!";

            foreach (int k in dict.Keys) WriteLine($"{k} --> {dict[k]}");
            WriteLine("-------------------------------------------------");
            var odict = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, v => v.Value);
            foreach (int k in odict.Keys) WriteLine($"{k} --> {odict[k]}");

            ReadKey();
        }
    }

    class MyComp : IComparer
    {
        public int Compare(object x, object y)
        {  
            return (int)(Math.Abs((double)x) - Math.Abs((double)y));
        }
    }
}
