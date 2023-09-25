using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda01 {
  class Program {
    static void Main(string[] args) {
      Func<string, int, int, string> showMe =
        (a, b, c) => string.Format(a, b, c, (b + c));
      Console.WriteLine(showMe("{0}+{1}={2}",3,5));
      Console.ReadKey();
    }
  }
}
