using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBiz {
  class Program {
    static void Main(string[] args) {
      Book[] books = {
                new Book("1111","C# is fun","C.K.Leng",52.7F),
                new Book("2222","Advanced C#","Ali",32.1F),
                new Book("3333","Defensive Programming in C#","Steven",44.4F),
                new Book("4444","How to be rich in a week?","John",999.9F),
            };
      Cart<Book> cart = new Cart<Book>();
      cart.Add(books[0], 10);
      cart.Add(books[1], 20);
      cart.Add(books[3], 5);
      cart.Remove(books[1], 10);
      cart.Remove(books[3]);
      cart.Add(books[0], 5);
      Console.WriteLine("Total:{0:$#,##0.00}", cart.GrandTotal);
      Console.WriteLine("Book with ISBN:4444 has {0} copies", cart["4444"].Quantity);
      Console.ReadKey();
    }
  }
}
