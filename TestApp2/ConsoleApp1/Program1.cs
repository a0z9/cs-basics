using static System.Console;

namespace krasn23.a0z9.learning {

    internal class Program1
    {
        static void Summator()
        {
            WriteLine("Summator, press 'x' to exit.. Enjoy!");
            int a, b;
            string sa, sb;

            while (true)
            {
                Write("Number1: "); sa = ReadLine();
                Write("Number2: "); sb = ReadLine();
                if (sb == "x" || sa == "x") break;

                if (int.TryParse(sa, out a) && int.TryParse(sb, out b))
                {
                    WriteLine($"{a} + {b} = {a + b}");
                }
                else { WriteLine("Wrong number format.."); }
            }
        }

        static double Summa(int mult=1, params double[] arr)
        {
            double summa = 0;
            foreach (double d in arr) summa += d;
            return summa*mult;
        }

        static double SummatorD(double[] arr) {
            double summa = 0;
            foreach (double d in arr) summa += d;
            return summa;
        }
        static int SummatorD(int[] arr)
        {
            int summa = 0;
            foreach (int d in arr) summa += d;
            return summa;
        }
        static void VarTest()
        {
            WriteLine("--- Test VArs ---");

            byte b1 = 12, b2 = byte.MaxValue - 2, b3 = 072, b4 = 0xa1;
            byte res;

            //checked
            //{
            res = (byte)(b2 + b1);
            //}

            WriteLine($"{EchoByte(b2)} + {EchoByte(b1)} = {EchoByte(res)} ");
            WriteLine($"{b2} + {b1} = " + $"{res}");

            short sh = 11;
            WriteLine($"Short: Max={short.MaxValue}, Min={short.MinValue}");
            WriteLine($"Short: Max={(1 << 15) - 1}, Min={-(1 << 15)}");

            // 0001_0101
            // << 1
            // 0010_1010

            //---------- int ------------

            int i1 = 22 + 444;

            //-------- long --------------
            long L1 = 296492364964926L;
            WriteLine($"Long: Max={long.MaxValue}, Min={long.MinValue}");
            WriteLine($"Long number of dec places: {Math.Log10(long.MaxValue)}");

            // ---- floats ------
            float f1 = 1.2345678901234567890f;
            WriteLine("f1=" + f1);

            double d1 = 1.2345678901234567890123456789;
            WriteLine("d1=" + d1);

            decimal dc1 = 1.23456789012345678901234567890123456789m;
            WriteLine("dc1=" + dc1);

            WriteLine(0.2m + 0.1m == 0.3m);
            WriteLine(0.2 + 0.1 == 0.3);

            // ------------------------------ OPs ---------------
            // bit: &, |, ^, ~
            // arithm: +,-,*,/,%,++,--

            byte ab1 = 0b1001_1100, ab2 = 0b0010_1000;
            WriteLine("------------ bit ops test -------------");
            WriteLine($"{"b1",10} -> {EchoBin(ab1)}");
            WriteLine($"{"b2",10} -> {EchoBin(ab2)}");
            WriteLine($"{"b1&b2",10} -> {EchoBin((byte)(ab1 & ab2))}");
            WriteLine($"{"b1|b2",10} -> {EchoBin((byte)(ab1 | ab2))}");
            WriteLine($"{"b1^b2",10} -> {EchoBin((byte)(ab1 ^ ab2))}");
            WriteLine($"{"b1^b2^b2",10} -> {EchoBin((byte)(ab1 ^ ab2 ^ ab2))}");
            WriteLine($"{"~b2",10} -> {EchoBin((byte)~ab2)}");
            WriteLine("------------ bit ops test -------------");





        }
        static void StringToVars()
        {
            string s1 = " 1111  ";
            int i = 0;
            WriteLine(int.TryParse(s1, out i));

            //int i = int.Parse(s1);
            WriteLine($"{i}*2 = {i * 2}");
            double d;
            WriteLine(double.TryParse("1.2330002e1", out d));
            WriteLine($"{d}*2 = {d * 2}");
        }
        static void ArrayTest()
        {
            int[] arr = new int[10];
            int[] arr2 = new[] { 1, 2, 3 - 33, 4, 5, -333 };
            int[] arr3 = new int[] { 10, -2, 3 - 33, 4, 5, -3,33 };
            int[] arr4 = [1, 2, 3 - 44, 5, 6, 77, 8];

            // arr2[7] = 111; //exception!!

            for (int i = 0; i < arr.Length; i++) arr[i] = i * i;
            WriteLine($"[{String.Join(',', arr)}]");
            printArray<int>(arr2);
            printArray(arr3);
            WriteLine("-------- Random Array ---------------");
            printArray<int>( getRandomInts(min: 10, N: 20, max: 150));
            printArray<int>(getRandomInts());

            WriteLine("-------- Summator Array Test ---------------");
            WriteLine($"S1={SummatorD(new double[] {1,2,3,4,5,6,7,8,9}) }");
            WriteLine($"S2={SummatorD(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } ) }");
            WriteLine($"S3={Summa(mult:10, (byte)1, 2.0d, 3.0f, (short)4, 5, 6, 7, 8, 9, 10)}");
            
            // 2d arrays
            int[,] arr2d = new int[3, 6];
            int[,] arr2d1 = new int[,] {
            {-100,2,3 },
            {2,6,0}
            };
            WriteLine($"rows:{arr2d.GetLength(0)}, cols:{arr2d.GetLength(1)}");

            // jagged arays
            int[][] jarr2d = new int[3][];
            jarr2d[0] = new int[1];
            jarr2d[1] = new int[5];
            jarr2d[2] = new int[2];




        }
        static void printArray<T>(T[] arr){
            Write("[");
            foreach (T t in arr) Write(t.ToString() + ",");
            Write("\b]\n");
        }

        static int[] getRandomInts(int N = 10, int min = -50, int max = 50)
        {
            int[] arr = new int[N];
            Random r = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < N; i++) arr[i] = r.Next(min, max); 
            return arr;
        }

        #region Echo Functions

        static string EchoByte(byte b)
        {
            return Convert.ToString(b, 2).PadLeft(8, '0');
        }

        static string EchoBin(byte b)
        {
            return Convert.ToString(b, 2).PadLeft(8 * sizeof(byte), '0');
        }

        static string EchoShort(short b)
        {
            return Convert.ToString(b, 2).PadLeft(8 * sizeof(short), '0');
        }

        static string EchoUShort(ushort b)
        {
            return Convert.ToString(b, 2).PadLeft(8 * sizeof(ushort), '0');
        }
        #endregion
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            //VarTest();
            //StringToVars();
            //Summator();
            ArrayTest();

            Write("Press any key .."); ReadKey();

        }
    }

   

  

}