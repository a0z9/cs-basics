using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//public delegate void NewBookHandler(string message);

namespace ConsoleDelegateActionsApp1
{
    internal class Library<T>
    {
        public delegate void NewBookHandler(string message);

        public event NewBookHandler? NewBook;
        private List<T> Books = new List<T>();

        public void AddBook(T book) { 
          Books.Add(book);
            NewBook?.Invoke($"{book} aded in catalog!!");
        
        }

    }
}
