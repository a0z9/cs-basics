using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApp1
{
    internal static class Extensions111
    {

        // hello ->  *H*E*L*L*O*
        //"hello".beautify(str:"*",upcase:true)

        public static string beautify0(this string s, string sep = "*", bool upcase = true)
        { 
         string strout = sep;
         if(String.IsNullOrEmpty(s)) return "";
         if (String.IsNullOrEmpty(sep)) sep = "*";
         if (upcase) s = s.ToUpper();
         foreach(char c in s.Trim()) { strout += new String(new char[]{c}) + sep;  }

         return strout;
        }

        public static string beautify(this string s, string sep = "*", bool upcase = true)
        {
            if (String.IsNullOrEmpty(s)) return "";
            if (String.IsNullOrEmpty(sep)) return upcase?s.ToUpper():s;
            StringBuilder sb = new StringBuilder();
            sb.Append(sep);

            if (upcase) s = s.ToUpper();
            foreach (char c in s.Trim()) { sb.Append(c).Append(sep); }

            return sb.ToString();
        }


        public static IMovable jump(this IMovable mv, int L, int angle)
        {
            int dx = (int)(L * Math.Cos(angle * Math.PI / 180));
            int dy = (int)(L * Math.Sin(angle * Math.PI / 180));
            Write("+Jump.. ");
            int oldAngle = (mv as Box).Angle;
            return mv.rotate(angle-oldAngle).move(dx, dy);
        }
    }
}
