using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegateActionsApp1
{
    internal class Book
    {
        private int _id;
        public string Author {  get; set; }
        public string Title { get; set; }   

        public int Id { get => _id; }

        public override string ToString() => $"Book: \"{Title}\" by {Author}. id:{_id}.";
       
    }
}
