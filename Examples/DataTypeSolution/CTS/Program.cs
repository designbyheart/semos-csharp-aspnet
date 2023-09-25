using System;

namespace CTS {
  class Program {
    static void Main(string[] args) {
      int a1 = 5;
      System.Int32 a2 = 5;
      Int32 a3 = 5;
      Console.WriteLine("a1 is {0}", a1.GetType().Name);
      Console.WriteLine("a2 is {0}", a2.GetType().Name);
      Console.WriteLine("a3 is {0}", a3.GetType().Name);
      Console.ReadKey();
    }
  }
}
