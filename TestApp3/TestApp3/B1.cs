using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krasn23.learning
{
    internal class B1:A1
    {
        public B1 Box { get; set; } 

        public override string getInfo() {
            return base.getInfo().Replace("A1 class","B1 class");
        }

    }
}
