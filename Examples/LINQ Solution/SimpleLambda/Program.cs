using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleLambda {
  class Program {
    static int Add(int x, int y) {
      return x+y;
    }
    //
    // Few thousands lines here....
    //
    static void Main(string[] args) {
      Func<int, int, int> m1 = Add;
      Func<int, int, int> m2 = delegate(int x, int y) { return x + y; };
      Func<int, int, int> m3 = (x, y) => (x + y);

      Console.WriteLine("m1={0}",m1(4,6));
      Console.WriteLine("m2={0}",m2(4,6));
      Console.WriteLine("m3={0}",m3(4,6));
      Console.ReadKey();
    }
  }
}
