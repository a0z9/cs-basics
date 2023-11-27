using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static krasn23.a0z9.learning.Library;

namespace krasn23.a0z9.learning
{
    [LibraryCapacity(LibCapacity.Huge)]
    internal class Library
    {
        public delegate void NewBookHandler(string message);
        public event NewBookHandler NewBook;    

        private List<Book> books;

        public Library(List<Book> books) { this.books = books; }
        public Library() { books = new List<Book>(); }

        public bool addBook(Book book)
        { books.Add(book);
            NewBook?.Invoke($"В каталог добавлена книга: {book.Title}.");
            return true;
        }

        //-------------- Books test ------------------

    }
}
