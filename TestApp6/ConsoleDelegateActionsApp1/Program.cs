global using static System.Console;
using System.Xml.Linq;

namespace ConsoleDelegateActionsApp1
{
    delegate void GreetsHandler(string greets);

    internal class Program
    {
        static void SayHello(string name) => WriteLine($"Hello, {name}!");
        static void SaySalute(string name) => WriteLine($"Salute, {name}!");
        static string SaySalute2(string name) => $"Salute, {name}!";

        static void Main(string[] args)
        {
            WriteLine("--- Delegate Test ---");
            GreetsHandler gs = SayHello;
            Action<string> act = SaySalute;
            Func<string, string> fn = SaySalute2;

            gs += name => WriteLine($"Привет, {name}!");
            gs += SaySalute;
            gs("Andrey");
            act("Бэзил");
            WriteLine("--- Delegate Test ---");
            gs -= SaySalute;
            gs("Basil");

            WriteLine("--- Event Test ---");

            Book b1 = new Book() { Author = "А Конан-Дойль", Title = "Затерянный Мир" };
            Book b2 = new Book() { Author = "А Конан-Дойль", Title = "Возвращение Ш.Холмса" };


            Library<Book> lib = new Library<Book>();
            lib.NewBook += s => WriteLine($"1: {s}");

            Library<Book>.NewBookHandler h1 = s => WriteLine($"2: {s}");
            lib.NewBook += h1;

            lib.AddBook(b1);

            lib.AddBook(b2);


        }
    }
}
