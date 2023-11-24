using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using static System.Console;

namespace krasn23.andestech.learning
{
    internal class Calculus
    {
        private readonly static string[] ops = { "+", "-", "/", ":", "*", "%", "^", "**" };
        private static void Summator1()
        {
            WriteLine("Calculator - summator, enter 'x' to exit.");

            while (true)
            {
                Write("Enter number1: "); string str1 = Console.ReadLine();

                Write("Enter number2: "); string str2 = Console.ReadLine();
                if (str1 == "x" || str2 == "x") { WriteLine("By!"); break; }

                str1 = str1.Replace(',', '.').Trim(); str2 = str2.Replace(',', '.').Trim();
                double res, d1, d2;

                if (!double.TryParse(str1, NumberStyles.Any,CultureInfo.InvariantCulture, out d1) ||
                    !double.TryParse(str2, NumberStyles.Any, CultureInfo.InvariantCulture, out d2))
                {
                    WriteLine("Wrong number format.."); continue;
                }

                checked { res = d1 + d2; }
                WriteLine($"{d1} + {d2} = {res}");
            }

        }
        
        public static void Summator2()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            WriteLine("Summator - only [+], enter 'x' to exit.");
           
            while (true)
            {
                Write("Enter number1: "); string str1 = Console.ReadLine();

                Write("Enter number2: "); string str2 = Console.ReadLine();
                if (str1 == "x" || str2 == "x") { WriteLine("By!"); break; }

                str1 = str1.Replace(',', '.').Trim(); str2 = str2.Replace(',', '.').Trim();
                double res=0, d1=0, d2=0;

                if (!double.TryParse(str1, out d1) || !double.TryParse(str2, out d2))
                {
                    WriteLine("Wrong number format.."); continue;
                }
                try { checked { res = d1 + d2; } } 
                catch { WriteLine("Overflow.."); continue; }

                WriteLine($"{d1} + {d2} = {res}");
            }

        }


        public static void Calc()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            WriteLine($"Calculator. Valid operator: [{string.Join(",",ops)}]. Enter 'x' to exit or 'h' to get help.");
            

            while (true)
            {
                Write("Enter expression: "); string expr = Console.ReadLine();

                if (expr == "x" ) { Write("~~~> Thank u to use Calc, by!\n~~~> Press any key.."); ReadKey(); break; }
                if (expr == "h")
                {
                    WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    WriteLine($"Допустимые операции: {string.Join(" ",ops)}");
                    WriteLine("Примеры:");
                    WriteLine("1.222 + 2.4");
                    WriteLine("5.67 / 101.23");
                    WriteLine("-22.345 : 94.32");
                    WriteLine("3.78 ** 7.6");
                    WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    continue;

                }
                    expr = expr.Replace(',', '.').Trim();

                string[] strs = expr.Split(new[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);

                if( strs.Length !=3 || !ops.Contains(strs[1]))
                {
                    WriteLine("Wrong expression format.."); continue;
                }
               
                double res = 0, d1 = 0, d2 = 0;
                
                if (!double.TryParse(strs[0].Trim(), out d1) || 
                    !double.TryParse(strs[2].Trim(), out d2))
                {
                    WriteLine("Wrong number format.."); continue;
                }
                switch (strs[1])
                        {
                            case"+": res = d1 + d2; break;
                            case "-": res = d1 - d2; break;
                            case "*": res = d1 * d2; break;
                            case "/": case ":":  res = d1 / d2; break;
                            case "^": case "**": res = Math.Pow(d1,d2); break;
                            case "%": res = d1*d2/100.0; break;
                             default: WriteLine("Wrong operation.."); continue;
                        }
                if(/*(res == 0 && d1 != 0 && d2 != 0) ||*/ double.IsInfinity(res) || double.IsNaN(res)) 
                { WriteLine("Overflow or result is not real value.."); continue; }

                WriteLine($"{d1} {strs[1]} {d2} = {res}");
            } 
        }
    }
}
