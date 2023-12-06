using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TestException
{
    internal class Program
    {
        static void TestDiv(int a) {
            int b = 1 / (a - 1);
        }

        static int getValue(uint idx)
        {
            int[] b = new int[] {1,2,-4,5,6 };
            return b[idx];
        }

        static void Main(string[] args)
        {
            try
            {
                int a = getValue(5);
                TestDiv(1);

                WriteLine("-- End of Try Block --");
            }
            catch (DivideByZeroException ex)
            {
                // Log exception to file(s), log to network, ....
                Console.WriteLine(ex + "\n------------------");
                throw new Exception("Rethrow ex!!", ex);
            }
            catch (IndexOutOfRangeException ex)
            {
                // Log exception to file(s), log to network, ....
                Console.WriteLine(ex + "\n------------------");
            }

            finally
            {
                WriteLine("-- Finally Block --");
            }


            WriteLine("-- End of Main --");
        }
    }
}
