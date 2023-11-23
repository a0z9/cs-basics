using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace krasn23.learning
{
    public class A1
    {
        private const int MAX = 300000;
        private int _data;  //field
        private static int counter;
        private static readonly string vendor;

        public static int Counter { get { return counter; } }


        static A1()
        {
            //....
            //
            WriteLine("+++ static ctor of class A1");
            vendor = "Kras";

        }

        public A1(int Data, string Message, string pmessage)
        {
            this.Data = Data;
            this.Message = Message;
            PrivateMessage = pmessage;
            counter++;
            WriteLine("+++ ctor of class A1, o:" + GetHashCode());
        }

        public A1(int data) : this(data, "Hello", "Private party")
        { }

        public A1() : this(8848, "Hello", "Private party") { }


        ~A1() {
            WriteLine("--- dtor of class A1, o:" + GetHashCode());
            //conn.close()

        }

        public string Message { get; set; }

        public string PrivateMessage { get; private set; }

        public int Data
        {
            get { return _data; }
            set
            {
                if (value >= MAX) throw new Exception("EXtra VAL!!!" + value);
                else
                {
                    _data = value;
                }
            }
        }

        public virtual string getInfo()
        {
            return $"A1 class, object:{GetHashCode()}, data={_data}, message={Message}, " +
                $"private message={PrivateMessage}.";

        }

    }
}
