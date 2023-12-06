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
        static int getValue(string sid)
        {
            return int.Parse(sid);
        }
        static void ExceptionTest() {
            try
            {
                int a = getValue(4);
                TestDiv(10);
                a = getValue("111a");

                WriteLine("-- End of Try Block --");
            }
            //catch (DivideByZeroException ex)
            //{
            //    // Log exception to file(s), log to network, ....
            //    Console.WriteLine(ex + "\n------------------");
            //    throw new Exception("Rethrow ex!!", ex);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    // Log exception to file(s), log to network, ....
            //    Console.WriteLine(ex + "\n------------------");
            //}

            catch (Exception ex) when
            (ex is IndexOutOfRangeException || ex is DivideByZeroException)
            {
                // Log exception to file(s), log to network, ....
                Console.WriteLine(ex + "\n------------------");
            }

            catch (Exception ex)
            {
                // Log exception to file(s), log to network, ....
                Console.WriteLine(ex + "\n------------------");
                throw new Exception("Rethrow ex!!", ex);
            }

            finally
            {
                WriteLine("-- Finally Block --");
            }

        }

        static void Main(string[] args)
        {
            //  ExceptionTest();
            Account acc = new Account(deposit: 1000);
            acc.Put(2000);
            acc.Put(10_000);
            WriteLine("Deposite:" + acc.Deposit);
            acc.Withdraw(9_000);
            acc.Withdraw(3_985);
            WriteLine("Deposite:" + acc.Deposit);

            WriteLine("-- End of Main --");
        }
    }
}
