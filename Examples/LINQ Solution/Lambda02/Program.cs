using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda02 {
  class Program {
    static void Main(string[] args) {
      List<int> data = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

      //var evenData = data.ForEach(item=>{(item%2)==0)};
      var evenData = data.Where(item=>(item%2)==0);
      //foreach (int item in evenData) Console.WriteLine(item);
      evenData.ToList<int>().ForEach(item => Console.WriteLine(item));
      Console.ReadKey();
    }
  }
}
