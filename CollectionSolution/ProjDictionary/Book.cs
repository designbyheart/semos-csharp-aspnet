using System;

namespace ProjDictionary {
  class Book {
    public string ISBN;
    public string Title;
    public string Author;
    public float  Price;
    public int    Year;
    public Book(string isbn, string title, string author, float price, int year) {
      ISBN = isbn;
      Title = title;
      Author = author;
      Price = price;
      Year = year;
    }
    public override string ToString() {
      return "ISBN:"+ISBN+",Title:\""+Title+"\",Author:"+
             Author+",Price:$"+Price+",Year:"+Year;
    }
  }
}
