using static System.Console;

static void LoopTest() {

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

WriteLine("Func Array Test");
//Summator();
{ int i = 22;}
{ int i = 1222;}

LoopTest();


ReadKey();

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