using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQLet {
  class Program {
    static void Main(string[] args) {
      var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

      var query = from n in list
                  where (n>3)&&(n<8)
                  let g = n * 2
                  where g%2==0
                  let newList = new List<int>(){2,3}
                  from l in newList
                  select new { l, r=g*l};

      foreach (var item in query) Console.WriteLine(item);

      Console.ReadKey();
    }
  }
}
