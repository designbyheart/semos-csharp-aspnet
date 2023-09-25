using System;
using System.Collections.Generic;

namespace ProjDictionary {
  class Program {
    static void Main(string[] args) {
      var books = new Dictionary<string, Book>();
      books.Add("111",new Book("111", "C# is Fun",   "Ali",   111.1F, 2017));
      books.Add("222",new Book("222", "Advanced C#", "Abu",   222.2F, 2019));
      books.Add("333",new Book("333", "C# or Java?", "Aaron", 333.3F, 2018));
      books.Add("444",new Book("444", "Excel in C#", "Ahmad", 444.4F, 2016));
      books.Add("555",new Book("555", "C# for Dummy","Azizi", 555.5F, 2018));
      books["666"] = new Book("666", "High Performance C#",  "C.K.Leng", 666.6F, 2023);
      Console.WriteLine("\n---------All Books-------------------");
      foreach(var book in books.Values) {
        Console.WriteLine(book);
      }
      Console.WriteLine("\n---------Just one Book-------------------");
      Console.WriteLine(books["444"]);
      Console.ReadKey();
    }
  }
}
