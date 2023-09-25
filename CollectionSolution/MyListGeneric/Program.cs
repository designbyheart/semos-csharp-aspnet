using System;

namespace ProjListGeneric {
  class Book {
    public readonly String ISBN;
    public readonly String Name;
    public float Price;
    public Book(String isbn, String name, float price) {
      ISBN = isbn;
      Name=name;
      Price = price;
    }
    public void Show() {
      Console.WriteLine("ISBN:{0}",ISBN);
      Console.WriteLine("Name:{0}", Name);
      Console.WriteLine("Price:{0:c}", Price);
      Console.WriteLine();
    }
  }
  class Program {
    static bool isPrime(int n) {
      int i;
      n = Math.Abs(n);
      for (i = 2; (i < n) && ((n % i) != 0); i++) ;
      return (i == n);
    }
    static void Main(string[] args) {
      MyList<Book> books = new MyList<Book>();

      books.Add(new Book("1111", "C# is Fun", 100.0F));
      books.Add(new Book("2222", "How to earn million in a week?", 999.9F));
      books.Add(new Book("3333", ".NET fundamentals", 150.0F));
      books.Add(new Book("4444", "To be Pro in C#", 300.0F));
      books.RemoveAt(2);
      books.Insert(1,new Book("5555", "How C3 is better than Java?", 250.0F));
      for(int i=0;i<books.Count;i++) books[i].Show();
      Console.WriteLine("First Book:"); books["First"].Show();
      Console.WriteLine("Last Book:"); books["Last"].Show();
      Console.WriteLine("Cheap Books:");
      foreach (Book book in books.Filter(Cheap)) book.Show();
      Console.ReadKey();
    }
    static bool Cheap(Object book) {
      return ((Book)book).Price < 200F;
    }

    static void Main2(string[] args) {
      MyList<int> ml = new MyList<int>();
      ml.Add(1);
      ml.Add(2);
      ml.Clear();
      Console.WriteLine(ml.isEmpty ? "List is Empty" : "List has item(s)");
      ml.Add(0);
      ml.Add(1);
      ml.Add(2);
      ml.Add(3);
      ml.Add(4);
      ml.Add(5);
      ml.Insert(2, 9);
      ml.RemoveAt(4);
      ml["Last"] = 97;
      ml.Add(7);
      ml.Add(8);
      ml.Add(9);
      ml.Add(10);
      ml.Add(11);
      for (int i = 0; i < ml.Count; i++) Console.WriteLine(ml[i]);
      Console.WriteLine("The first Item is {0}", ml["First"]);
      Console.WriteLine("The last Item is {0}", ml["Last"]);

      Console.WriteLine("-----The Odd Numbers----");
      foreach (int item in ml.Filter(IsOdd)) Console.WriteLine(item);
      foreach (int item in ml.Filter(delegate(Object obj){ return (((int)obj) % 2) != 0;})) Console.WriteLine(item);
      foreach (int item in ml.Filter(obj => (((int)obj) % 2) != 0)) Console.WriteLine(item);
      Console.WriteLine("-----The Even Numbers----");
      foreach (int item in ml.Filter(IsEven)) Console.WriteLine(item);
      foreach (int item in ml.Filter(delegate(Object obj) { return (((int)obj) % 2) == 0; })) Console.WriteLine(item);
      foreach (int item in ml.Filter(obj => (((int)obj) % 2) == 0)) Console.WriteLine(item);
      Console.WriteLine("-----The Prime Numbers----");
      foreach (int item in ml.Filter(IsPrime)) Console.WriteLine(item);
      foreach (int item in ml.Filter(delegate(Object obj) { return isPrime((int)obj); })) Console.WriteLine(item);
      foreach (int item in ml.Filter(obj => isPrime((int)obj))) Console.WriteLine(item);
      Console.ReadKey();
    }
    static bool IsOdd(Object obj) {
      return (((int)obj)%2)!=0;
    }
    static bool IsEven(Object obj) {
      return (((int)obj) % 2) == 0;
    }
    static bool IsPrime(Object obj) {
      return isPrime((int)obj);
    }
  }
}
