using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace TestOperator {
  class Program {
    static void Main(string[] args) {
      int a = 22;
      int b = 7;
      double d = a / (float)b;
      Console.WriteLine("d={0:f2}", d);
      Console.ReadKey();
    }
  }
}

