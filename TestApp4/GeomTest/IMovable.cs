using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomTest
{
    internal interface IMovable
    {
       void mv(int dx, int dy);
       void rotate(int degrees);
    }
}
