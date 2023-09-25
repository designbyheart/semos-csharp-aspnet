using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQAdvanced01 {
  class Program {
    static void Main(string[] args) {
      var query = from method in typeof(System.Linq.Enumerable).GetMethods()
                  where method.DeclaringType==typeof(Enumerable)
                  orderby method.Name 
                  group method by method.Name into g
                  select new {Name=g.Key, Overloads=g.Count()};

      foreach (var item in query) Console.WriteLine(item);
      
      Console.ReadKey();
    }
  }
}
