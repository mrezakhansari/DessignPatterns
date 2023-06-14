using System.Text;

namespace DesignPatterns.Prototype
{
    public class BookShop : ICloneable
    {
        private string shopName;
        List<Book> books = new List<Book>();

        public string ShopName { get => shopName; set => shopName = value; }
        public List<Book> Books { get => books; set => books = value; }

        public object Clone()
        {
            // shallow copy
            //return this.MemberwiseClone();
            // or deep clone : 
            BookShop bookShop = new BookShop();
            for (int i = 0; i < books.Count; i++)
            {
                Book book = new Book();
                book.BookId = Books[i].BookId;
                book.BookName = Books[i].BookName;
                bookShop.Books.Add(book);
            }
            return bookShop;
        }

        public void LoadData()
        {
            for (int i = 0; i < 10; i++)
            {
                Book book = new Book();
                book.BookId = i;
                book.BookName = $"Book {i}";
                books.Add(book);
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"BookShop [ShopName={ShopName}]\n");
            for (int i = 0; i < books.Count; i++)
            {
                sb.Append($"Book Id={Books[i].BookId} , Book Name={Books[i].BookName}\n");
            }
            return sb.ToString();
        }
    }
}
