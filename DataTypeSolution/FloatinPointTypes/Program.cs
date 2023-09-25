using System;

namespace FloatingPointTypes {
  class Program {
    static void Main(string[] args) {
      float    f = 22.0F / 7;
      double   d = 22.0D / 7;
      decimal de = 22.0M / 7;

      Console.WriteLine("sizeof(float) is {0}", sizeof(float));
      Console.WriteLine("sizeof(double) is {0}", sizeof(double));
      Console.WriteLine("sizeof(decimal) is {0}", sizeof(decimal));
      Console.WriteLine("f={0}", f);
      Console.WriteLine("d={0}", d);
      Console.WriteLine("de={0}",de);
      Console.ReadKey();
    }
  }
}
