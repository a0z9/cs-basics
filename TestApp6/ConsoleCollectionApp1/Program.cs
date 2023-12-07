﻿
global using static System.Console;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleCollectionApp1
{
    internal class Program
    {
        static void echo(ICollection lst)
        {
            Write("{");
            foreach(object o in lst) Write($"{o},");
            if (lst.Count != 0) Write("\b");
            WriteLine("}");
        }

        static void Main(string[] args)
        {
            WriteLine("---- Collection Test ----");

            IList arr1 = new ArrayList() {1,2,3,"111",-20,1.2222m, new int[] {1,2,3 } };
            
            if (arr1 is ArrayList al1) { WriteLine(al1.Capacity); }
            // analog
            if (arr1.GetType() == typeof(ArrayList))
            { ArrayList al2 = (ArrayList)arr1; }

            arr1.Add('a'); arr1.Add(111e-12); arr1.Add(-11);
            if (arr1 is ArrayList al3) { WriteLine(al3.Capacity); }

            ArrayList Inv1 = ["AA123", "BB12312", "AA21376"];

            echo(arr1);
            echo(new ArrayList() { });

            List<int> iarr = [-22, 3, 4, 5, -10, 3, 2, 6,55,6,7];
            iarr.AddRange(new int[] { 1, 2, 30 });
            echo(iarr);
            //LINQ
            var res1 = (from int d in iarr
                        where d > -15
                        orderby d*d descending
                        select d * d).ToList<int>();
            
            echo(res1);

            var res2 = iarr.Where<int>(v => v > -15).
                OrderByDescending(x => x*x).
                Select(x => x * x).ToList();
            
            echo(res2);

            WriteLine("------------- Comparer test ----------- ");
            iarr.Sort(Comparer<int>.Create( (a,b) => a-b  ) );
            echo(iarr);
            iarr.Sort(Comparer<int>.Create(comp));
            echo(iarr);
            iarr.Sort(new MyCompare());


            // WriteLine(String.Join(",", arr1));



        }
        static int comp(int a, int b) { return b - a; }
      
    }

    class MyCompare : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x - y;
        }
    }
}
