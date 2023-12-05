using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApp1
{
    internal class Program
    {
        static void MoveCastleLevel1Path(IMovable mv) {
            mv.move(1, 1).rotate(25).
               move(-10, 2).
               move(2, 3).
               jump(10,45);
        
        }

        static void testArr() {
            int[] arr = new int[2];
            arr[2] = 11;
        }

        static void Main(string[] args)
        {
         Monster monster = new Monster();
            WriteLine(monster);
            MoveCastleLevel1Path(monster);
            WriteLine(monster);
            WriteLine("Game test ".beautify());

            WriteLine("------- Exceptions -------");

            try
            {
                int a = 1, b = 10 / (10 - a);
                object o = new int[] { 1, 2, 3 };
                //testArr();
                //int c = (int)o;
            }
            catch (DivideByZeroException ex)
            {
                WriteLine(ex);
#if RELEASE
                // Log.
#endif
            }
            catch (InvalidCastException ex)
            {
                WriteLine(ex);

            }

            catch (Exception ex)
            {
                //Log....
                throw new Exception("Some extra exception..", ex);
                //throw ex;
            }

            finally { WriteLine("Finally block"); }

            Account acc = new Account();
            acc.Put(900);
            //acc.Withdraw(901);
            acc.Put(1900);


            WriteLine("End of Main.");
     }
    }
}
