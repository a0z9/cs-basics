using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krasn23.a0z9.learning
{
    internal class Book
    {
        private int _id;
        public string Author { get; set; }
        public string Title{ get; set; }

        public int Id { get => _id; }

        public override string ToString()
        {
            return $"Book: \"{Title}\", автор: \"{Author}\". ";
        }

    }
}
