using System.Collections;
using static System.Console;

namespace krasn23.a0z9.learning
{
    enum LogSeverity
    {
        NoLog, Info, Low, Middle, High
    }

    enum FileAccesMode
    {
        Read = 0b0001,
        Write = 0b0010,
        Execute = 0b0100
    }

    internal class Program
    {
        static void Summator()
        {
            WriteLine("Summator of int, press 'x' to exit.");
            int a1, a2;
            string s1, s2;

            while (true)
            {
                Write("Number1="); s1 = ReadLine();
                Write("Number2="); s2 = ReadLine();
                if (s1 == "x" || s2 == "x") { WriteLine("By."); break; }

                if (int.TryParse(s1, out a1) && int.TryParse(s2, out a2))
                { WriteLine($"{a1} + {a2} = {a1 + a2}"); }
                else { WriteLine("Wrong format!!!"); }
            }
        }
        static double Summ1(double[] arr) { 
        double sum = 0;
        foreach( double d in arr ) { sum += d;}
        return sum;
        }
        static double Summ2(params double[] arr) => Summ1(arr);
        static int[] GetRandomInts(int N = 10, int min = -100, int max = 100)
        {
            int[] arr = new Int32[N];
            Random r = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < N;i++) arr[i] = r.Next(min, max);
            return arr;
        }
        static void LoopTest()
        {

            for (int i = 5, k = 1; i > -1 && k < 5; i -= 2, k++)
            {
                WriteLine($"i={i}, k={k}");
            }

            {
                int i = 0;
                for (; ; )
                {
                    if (i > 4) break;
                    WriteLine($"i=>{i}");
                    //..
                    i++;
                }
            }

            for (int i = 0; i <= 4; i++) WriteLine($"i=>{i}");
            WriteLine("--------------------------------------");
            int j = 5;
            do
            {
                WriteLine($"j=>{j}");
                --j;
            }
            while (j >= 0);
            WriteLine("--------------------------------------");
        }
        static bool F1(in int a, out int data)
        {
            int b = a;
            // a++;
            data = b;
            return true;
        }
        static (int, int) F2(in int a)
        {
            int b = a;
            // a++;
            //data = b;
            return (a+1,a-1);
        }

        static void echo(IEnumerable data)
        { 
         Write("[");
         foreach(var item in data) Write(item + ",");
         WriteLine("\b]");    
        }

        private static void Main(string[] args)
        {
            WriteLine("Func Array Test");
            //Summator();
            { int i = 22; }
            { int i = 1222; }
            //LoopTest();

            int[] arr = [1, 2, 3, -20, 4, -4]; // .net > 6
            int[] arr2 = new int[] { 10, -2, 3, -20, 4, -4 };
            int[] arr3 = new int[10];
            arr[4] = 77;

            for (int i = 0; i < arr.Length; i++) WriteLine($"arr[{i}]={arr[i]}");
            WriteLine("--------------------------------------");
            Write("[");
            foreach (int d in arr) Write(d + ", ");
            if (arr.Length != 0) Write("\b\b");
            WriteLine("]");

            WriteLine("------- Main Args --------------");
            if (args.Length > 0)
                foreach (string a in args)
                {
                    switch (a)
                    {
                        case "-h": case "/h": case "--help": WriteLine("Help page: How to use prog...."); goto end_args;
                        case "-m": WriteLine("m param: How tu use prog...."); break;
                        default: WriteLine("Wrong args!!!"); goto end_args;
                    }
                    WriteLine(a);
                }
            end_args:  
            // ---------- switch/case
            LogSeverity ls = LogSeverity.Middle;
            switch (ls)
            {
                case LogSeverity.Info: WriteLine("Info"); break;
                case LogSeverity.Middle: WriteLine("Middle"); break;
                //....
                default: WriteLine("Wrong Log!!"); break;
            }
            // func test 
            WriteLine(" ------------ FUNC TEST ----------- ");
            WriteLine("Summa=" + Summ1([1,2,3,4,5,6,7,8,9]));
            WriteLine("Summa=" + Summ1(new double[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9}));
            WriteLine("Summa=" + Summ2(1, 2, 3, 4, 5, 6, 7, 8, 9));

           
            WriteLine($"[{String.Join(',',GetRandomInts())}]");
            echo(GetRandomInts());

            WriteLine(" ------------ TUPLE FUNC TEST ----------- ");
            int g1, g2;
            (g1, g2) = F2(11);
            WriteLine($"g1={g1}, g2={g2}.");

            (int v1, int v2) tuple = (1, 1);
                
            tuple =    F2(22);
            WriteLine($"v1={tuple.v1}, v2={tuple.v2}.");


            ReadKey();


        }
    }
}

