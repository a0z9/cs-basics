using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExceptionGenericTest
{
    internal class Program
    {
        static void ExceptionTest()
        {

            string a = "111aa";
            int[] arr = new int[3];
            try
            {
                arr[1] = -222;
                //arr[3] = 1;
                //T();
                int i = int.Parse(a);
            }
            catch (IndexOutOfRangeException ex)
            {
                // Write to syslog, net log, ....
                WriteLine("Index Error!!!\n" + ex);
            }
            catch (DivideByZeroException ex)
            {
                // Write to syslog, net log, ....
                WriteLine("Zero devide Error!!!\n" + ex);
            }
            catch (Exception ex)
            {
                // Write ex to syslog, net log, ....
                WriteLine("Any other Error!!!\n" + ex);
                throw new Exception(ex.Message, ex);

            }
            finally
            {
                WriteLine("Finally block");
            }

        }
        static void T() {
            int a = 1, b = 1 / (1 - a);
        }
        static void AccountTest() {
            Account acc = new Account(50);
            acc.Put(10_000);
            acc.Put(100_000);

        }

        static void Main(string[] args)
        {
            //ExceptionTest();
            AccountTest();

            WriteLine("End of main...");
            ReadKey();
        }
    }
}
