using System;

namespace Overflow {
  class Program {
    static void Main(string[] args) {
      int n = int.MinValue;
      Console.WriteLine("BEFORE:n={0}", n);
      checked {

        unchecked {
          n = n - 1;
        }


      }
      Console.WriteLine("AFTER:n={0}", n);
      Console.ReadKey();
    }
  }
}
