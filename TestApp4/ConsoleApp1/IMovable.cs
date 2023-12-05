using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IMovable
    {
        IMovable move(int dx, int dy);
        IMovable rotate(int angle);
        //IMovable jump(int L, int angle);

    }
}
