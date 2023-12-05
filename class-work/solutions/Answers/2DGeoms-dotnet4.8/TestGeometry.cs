using System;
using System.Threading;

using static System.Console;

namespace krasn23.a0z9.learning
{
    internal class TestGeometry
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            WriteLine("------------ 2D Geom Test ------------");
            Circle c1 = new Circle(10);
            c1.Coords = new Coords2D(10, 10);   

            WriteLine(c1);
            c1.b = 1;
            c1.a = 5;
            WriteLine(c1);
            Ellipse c2 = new Circle();
            WriteLine($"{c2.GetType()},  {c2 is Circle}, {c2 is Ellipse}, {c2 is Figure} ");
            WriteLine(c2);
            Figure e1 = new Ellipse(1,2,new Coords2D(-10,2));
            WriteLine(e1);
            Figure r1 = new Rectangle(10,2);
            WriteLine(r1);
            Rectangle s1 = new Square(10);
            WriteLine(s1);

            ReadKey();
        }
    }
}
