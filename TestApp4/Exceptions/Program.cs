
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
            catch(IndexOutOfRangeException e) {
                WriteLine($"1. Exception: {e.Source}, message: {e.Message}");

            }

            catch (Exception e)
            {
                WriteLine($"2. Math Exception: {e.Source}, message: {e.Message}");

            }
            finally {
                WriteLine("Finally block..");
            }

            WriteLine("End of file..");
            ReadKey();
        }
    }
}
