using System;

namespace TestInteger {
  class Program {
    static void Main(string[] args) {
      uint  n = 0;//-2147483648 .. 2147483647
      
      int x = 22, y = 7;
      double d = x / y;

      Console.WriteLine("n is {0}", n);
      Console.ReadKey();
    }
  }
}
