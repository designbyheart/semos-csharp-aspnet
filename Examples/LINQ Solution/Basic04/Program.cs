using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQReflection {
  class Program {
    static void Main(string[] args) {
      var query = from m in typeof(string).GetMethods()
                  where (m.IsStatic==true)
                  select m;
      foreach(var m in query) Console.WriteLine(m);
      Console.ReadKey();      
    }
  }
}
