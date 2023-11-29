using static System.Console;

Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

//VarTest();
StringToVars();


Write("Press any key ..");  ReadKey();



static void VarTest() {
    WriteLine("--- Test VArs ---");

    byte b1 = 12, b2 = Byte.MaxValue - 2, b3 = 072, b4 = 0xa1;
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
    WriteLine($"{"~b2",10} -> {EchoBin((byte)(~ab2))}");
    WriteLine("------------ bit ops test -------------");





}
static void StringToVars()
{
    string s1 = " 1111  ";
    int i=0;
    WriteLine(int.TryParse(s1, out i));

    //int i = int.Parse(s1);
    WriteLine($"{i}*2 = {i*2}");
    double d;
    WriteLine(double.TryParse("1.2330002e1", out d));
    WriteLine($"{d}*2 = {d * 2}");
}
#region Echo Functions

static string EchoByte(byte b) {
    return Convert.ToString(b, 2).PadLeft(8, '0');
}

static string EchoBin(byte b)
{
    return Convert.ToString(b, 2).PadLeft(8*sizeof(byte), '0');
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