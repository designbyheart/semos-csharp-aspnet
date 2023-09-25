using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaUseLocal {
  class Program {
    static void Main(string[] args) {
      int n=0;
      Func<int> func = () => { n = 6; return 2*n; };
      Console.WriteLine("func()={0}", func());
      Console.WriteLine("n={0}", n);
      Console.ReadKey();
    }
  }
}
