using System.Reflection;
using System.IO;
using System.Text;

using static System.Console;

namespace krasn23.a0z9.learning
{
    internal class AttribTest { 

        static void Main(string[] args)
        {
            Console.WriteLine("---- LibraryTest ----- ");
            Type typeLib = typeof(Library);

            LibraryCapacityAttribute? lca =
               typeLib.GetCustomAttribute<LibraryCapacityAttribute>();
            //  typeLib.GetCustomAttribute(typeof(LibraryCapacityAttribute)) as LibraryCapacityAttribute;
            WriteLine("LibCapacity=" + lca?.Capacity);

            //---------- Books test
            WriteLine("----------------------------");
            Type type = typeof(Book);
            PropertyInfo[] props =
                type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in props) WriteLine(prop);

            FieldInfo? fi = type.GetField("_id",
                BindingFlags.Instance | BindingFlags.NonPublic);
            WriteLine(fi);
            Book book = new Book() { Author = "London J.", Title = "White Silence" };
            WriteLine("Book Id:" + book.Id);
            fi?.SetValue(book, 11111);
            WriteLine("Book Id:" + book.Id);

            //---------------IO test----------------------------
            WriteLine("----------IO Test-----------");

            File.WriteAllText("file1.txt",
                "Hello!\nHi\nСалют!", Encoding.UTF8);

            File.Copy("file1.txt",
                        $"file1_{DateTime.Now:yyyy.MM.dd.mm.ss.fff}.txt");

            string[] lines = File.ReadAllLines("file1.txt", Encoding.UTF8);
            foreach (var item in lines)
            {
                WriteLine(item);
            }

            using (FileStream fs = new FileStream("file2.txt", FileMode.Append))
            {

                string data = $"DAta: {DateTime.Now:yyyy.MM.dd.mm.ss.fff}.txt\n";
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                fs.Write(buffer, 0, buffer.Length);

            }
            WriteLine("------------ File Data -------------");
            using (FileStream fs = new FileStream("file2.txt", FileMode.Open))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);

                string data = Encoding.UTF8.GetString(buffer);
                WriteLine(data);

            }


        }
    }
}
