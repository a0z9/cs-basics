using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

using static System.Console;

namespace krasn23.a0z9.learning
{
    internal class Calculus
    {
        private readonly static string[] ops = { "+", "-", "/", ":", "*", "%", "^", "**" };
        private readonly static char[] spec = "*+^".ToCharArray();
        private readonly static string sop;

        static Calculus() {
            // Готовим строку  для паттерна regexp
            sop =  String.Join("|",
                   ops.Select(op =>
                   {
                       string op2 = "";
                       foreach (char ch in op.ToCharArray())
                       {
                           if (spec.Contains<char>(ch)) op2 += new string(new char[] { '\\', ch });
                           else op2 += new string(new[] { ch });
                       }
                       return op2;
                   }));
#if DEBUG
            WriteLine("Regexp string for opps:" + sop);
#endif
        }

        private static void Summator1()
        {
            WriteLine("Calculator - summator, enter 'x' to exit.");

            while (true)
            {
                Write("Enter number1: "); string? str1 = ReadLine();

                Write("Enter number2: "); string? str2 = ReadLine();
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
                Write("Enter number1: "); string str1 = ReadLine();

                Write("Enter number2: "); string str2 = ReadLine();
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

        public static void Calc1()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            WriteLine($"Calculator. Valid operator: [{string.Join(",",ops)}]. Enter 'x' to exit or 'h' to get help.");
            

            while (true)
            {
                Write("Enter expression: "); string expr = Console.ReadLine();

                if (expr == "x" ) { Write("~~~> Thank U to use Calc, bye!\n~~~> Press any key.."); ReadKey(); break; }
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
        public static void Calc2()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            WriteLine($"Calculator. Valid operator: [{string.Join(",", ops)}]. Enter 'x' to exit or 'h' to get help.");
            while (true)
            {
                Write("Enter expression: "); string? expr = ReadLine();

                if (expr == "x") { Write("~~~> Thank U to use Calc, bye!\n~~~> Press any key.."); ReadKey(); break; }
                if (expr == "h")
                {
                    WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    WriteLine($"Допустимые операции: {string.Join(" ", ops)}");
                    WriteLine("Примеры:");
                    WriteLine("1.222+ 2.4");
                    WriteLine("5.67 / -101.23");
                    WriteLine("-22.345 : 94.32");
                    WriteLine("3.78 ** 7.6");
                    WriteLine("3.78e11 ^ 1.23");
                    WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    continue;

                }
                expr = expr?.Replace(',', '.').Replace("_", "").Trim();
               // UInt128 u;
               // Decimal d;
                
                
                // number format for double
                var r = new Regex(@"^(?<left>[+-]?\d*\.?\d+(e\d|e\+\d|e-\d)?\d*\s*)" +
                                  $@"(?<op>{sop})" +
                                  @"(?<right>\s*[+-]?\d*\.?\d+(e\d|e\+\d|e-\d)?\d*)$"
                                  , RegexOptions.IgnoreCase);

                if (expr==null || !r.IsMatch(expr)) { WriteLine("Wrong expression format.."); continue; }

                Dictionary<string, string> strs =
                    new Dictionary<string, string>
                    { {"left","" }, {"op","" }, {"right","" } };

                foreach (Match match in r.Matches(expr))
                {
                    foreach (Group group in match.Groups)
                    {
                        strs[group.Name] = group.Value.Trim();
#if DEBUG
                        WriteLine(group.Name + " ---> " + group.Value);
#endif
                    }
                }
                double res = 0, d1 = 0, d2 = 0;

                if (!double.TryParse(strs["left"], out d1) || !double.TryParse(strs["right"], out d2))
                {
                    WriteLine("Wrong number format.."); continue;
                }
                switch (strs["op"])
                {
                    case "+": res = d1 + d2; break;
                    case "-": res = d1 - d2; break;
                    case "*": res = d1 * d2; break;
                    case "/": case ":": res = d1 / d2; break;
                    case "^": case "**": res = Math.Pow(d1, d2); break;
                    case "%": res = d1 * d2 / 100.0; break;
                    default: WriteLine("Wrong operation.."); continue;
                }
                if (/*(res == 0 && d1 != 0 && d2 != 0) ||*/ double.IsInfinity(res) || double.IsNaN(res))
                { WriteLine("Overflow or result is not real value.."); continue; }

                WriteLine($"{d1} {strs["op"]} {d2} = {res}");
            }
        }
        
        public static void Calc3()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            WriteLine($"Calculator. Valid operator: [{string.Join(",", ops)}]. Enter 'x' to exit or 'h' to get help.");
            while (true)
            {
                Write("Enter expression: "); string expr = Console.ReadLine();

                if (expr == "x") { Write("~~~> Thank U to use Calc, bye!\n~~~> Press any key.."); ReadKey(); break; }
                if (expr == "h")
                {
                    WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    WriteLine($"Допустимые операции: {string.Join(" ", ops)}");
                    WriteLine("Примеры:");
                    WriteLine("1.222+ 2.4");
                    WriteLine("5.67 / -101.23");
                    WriteLine("-22.345 : 94.32");
                    WriteLine("3.78 ** 7.6");
                    WriteLine("3.78e11 ^ 1.23");
                    WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    continue;

                }
                expr = expr.Replace(',', '.').Replace("_","").Trim();

                // number format for double
                var r = new Regex(@"^(?<left>[+-]?\d*\.?\d+(e\d|e\+\d|e-\d)?\d*\s*)" +
                                  $@"(?<op>{sop})" +
                                  @"(?<right>\s*[+-]?\d*\.?\d+(e\d|e\+\d|e-\d)?\d*)$"
                                  , RegexOptions.IgnoreCase);

                if (!r.IsMatch(expr)) { WriteLine("Wrong expression format.."); continue; }

                Dictionary<string, string> strs =
                    new Dictionary<string, string>
                    { {"left","" }, {"op","" }, {"right","" } };

                foreach (Match match in r.Matches(expr))
                {
                    foreach (Group group in match.Groups)
                    {
                        strs[group.Name] = group.Value.Trim();
#if DEBUG
                        WriteLine(group.Name + " ---> " + group.Value);
#endif
                    }
                }

                double res = 0, d1 = 0, d2 = 0;

                if (!double.TryParse(strs["left"], out d1) ||
                    !double.TryParse(strs["right"], out d2))
                {
                    WriteLine("Wrong number format.."); continue;
                }
                switch (strs["op"])
                {
                    case "+": res = d1 + d2; break;
                    case "-": res = d1 - d2; break;
                    case "*": res = d1 * d2; break;
                    case "/": case ":": res = d1 / d2; break;
                    case "^": case "**": res = Math.Pow(d1, d2); break;
                    case "%": res = d1 * d2 / 100.0; break;
                    default: WriteLine("Wrong operation.."); continue;
                }
                if (/*(res == 0 && d1 != 0 && d2 != 0) ||*/ double.IsInfinity(res) || double.IsNaN(res))
                { WriteLine("Overflow or result is not real value.."); continue; }

                WriteLine($"{d1} {strs["op"]} {d2} = {res}");
            }
        }
    }
}
