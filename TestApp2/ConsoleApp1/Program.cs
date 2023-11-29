using static System.Console;


WriteLine("--- Test VArs ---");

byte b1 = 12, b2 = Byte.MaxValue-2, b3 = 072, b4 = 0xa1;

byte res = (byte)(b2 + b1);

WriteLine($"{EchoByte(b2)} + {EchoByte(b1)} = { EchoByte(res)} ");
WriteLine($"{b2} + {b1} = " +   $"{res}");

Write("Press any key ..");  ReadKey();

static string EchoByte(byte b) {
    return Convert.ToString(b, 2).PadLeft(8, '0');
}