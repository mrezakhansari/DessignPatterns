
using DesignPatterns.Prototype;


//BookShop bookShop1 = new BookShop();
//bookShop1.ShopName = "BookShop 1";
//bookShop1.LoadData();
//Console.WriteLine(bookShop1);


//BookShop bookShop2 = new BookShop();
//bookShop1.ShopName = "BookShop 2";
//bookShop1.LoadData();
//Console.WriteLine(bookShop1.GetHashCode());
//Console.WriteLine(bookShop2.GetHashCode());
//// ta eenja har do be do noghteye joda az hafezeh eshareh mikonan

//bookShop2 = bookShop1;
//Console.WriteLine(bookShop2);
//// vaghti chenin kari konim har do be ye noghte az hafezeh eshare mikonan

//Console.WriteLine(bookShop1.GetHashCode());
//Console.WriteLine(bookShop2.GetHashCode());

BookShop bookShop1 = new BookShop();
bookShop1.ShopName = "BookShop 1";
bookShop1.LoadData();
Console.WriteLine(bookShop1);

BookShop bookShop2 = (BookShop) bookShop1.Clone();
bookShop2.ShopName = "BookShop 2";
bookShop2.Books[2].BookName = "New Book 2";
Console.WriteLine(bookShop1);
Console.WriteLine(bookShop2);

Console.WriteLine(bookShop1.GetHashCode());
Console.WriteLine(bookShop2.GetHashCode());



