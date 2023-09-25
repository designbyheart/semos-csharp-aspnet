using System;

namespace ProjMyList {
  class Program {
    static void Main(string[] args) {
      MyList ml = new MyList();
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
      Console.WriteLine("The first Item is {0}",ml["First"]);
      Console.WriteLine("The last Item is {0}", ml["Last"]);
      Console.WriteLine("-----The Odd Numbers----");
      foreach (int item in ml.Odds) Console.WriteLine(item);
      Console.WriteLine("-----The Even Numbers----");
      foreach (int item in ml.Evens) Console.WriteLine(item);
      Console.WriteLine("-----The Prime Numbers----");
      foreach (int item in ml.Primes) Console.WriteLine(item);
      Console.ReadKey();
    }
  }
}
