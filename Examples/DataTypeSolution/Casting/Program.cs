using System;

namespace Casting {
  class Program {
    static void Main(string[] args) {
      int i = 100;
      long l = i;
      int i2 = (int)l;
      Console.WriteLine("l={0}",l);
      Console.ReadKey();
    }
  }
}
