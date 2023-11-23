
using static System.Console;

namespace krasn23.learning
{
    public class A {
        public int data;  //field
    }

    public class A1
    {
        private const int MAX = 300000;
        private int _data;  //field
        public A1(int data, string message, string pmessage)
        {
            Data = data;
            Message = message;
            PrivateMessage = pmessage;
        }

        public A1(int data) : this(data, "Hello", "Private party")
        { }

        public A1() : this(8848, "Hello", "Private party") { }


        public string Message { get; set; }

        public string PrivateMessage { get; private set; }

        public int Data
        {
            get { return _data; }
            set {
                if (value >= MAX) throw new Exception("EXtra VAL!!!" + value);
                else
                {
                    _data = value;
                }
            }
        }

        //public int getData() { return _data; }
        //public void setData(int value) { _data = value; }

        public string getInfo() {
            return $"A1 class, object:{GetHashCode()}, data={_data}, message={Message}, " +
                $"private message={PrivateMessage}.";

        }

    }

    class B {
        public int data;
    
    
    }




    internal class Prog {
        static void Main(string[] args)
        {
            WriteLine("------- CLASS TEST -------");
            A a;
            a = new A(); a.data = 123;
            WriteLine($"a object: {a.GetHashCode()}");

            B b1 = new B { data = 456 };
            B b2 = new B { data = 456 };
            WriteLine($"b1 object: {b1.GetHashCode()}");
            WriteLine($"b2 object: {b2.GetHashCode()}");
            WriteLine(b1 == b2);

            B b3 = b2, b4=b3;
            b3.data = 111;
            WriteLine($"b2.data: {b2.data}");
            WriteLine($"b3 object: {b3.GetHashCode()}");

            string s1 = "aaaa";
            string s2 = new string("aaaa");
            //---------------------------------------------------
            WriteLine("-------------------");
            A1 aa1 = new A1(123);
            WriteLine(aa1.getInfo());
            aa1.Data = 3000;
            WriteLine(aa1.getInfo());


        }
    }
}