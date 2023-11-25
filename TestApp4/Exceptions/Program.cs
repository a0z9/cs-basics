
using Exceptions;
using static System.Console;

namespace game.krasn23.learning
{
    class GameTest
    {


        static void Main(String[] arr)
        {

            int[] a = { 1, 2, 3 };

            try
            {
                a[2] = 1;
                int b = 1 / (a[2] - 1);

            }
            catch (IndexOutOfRangeException e)
            {
                WriteLine($"1. Exception: {e.Source}, message: {e.Message}");

            }

            catch (Exception e)
            {
                WriteLine($"2. Math Exception: {e.Source}, message: {e.Message}\n {e}");
                //Log, sent to external Log , etc..
                // throw new Exception();
                //throw e;
            }
            finally{
                WriteLine($"Finally block..");
            }

            Account acc = new Account(500);
            acc.Withdraw(490);



            WriteLine("End of file..");
            ReadKey();
        }
    }
}
