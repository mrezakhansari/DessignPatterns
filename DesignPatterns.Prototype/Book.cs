using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class Book
    {
        private int bookId;
        private string bookName;

        public int BookId { get => bookId; set => bookId = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public override string ToString()
        {
            return $"Book [BookId={bookId} BookName={bookName}]";
        }
    }
}
