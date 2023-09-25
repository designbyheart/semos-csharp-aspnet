using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQListInitializer {
  class Program {
    static void Main(string[] args) {
      List<int> data1 = new List<int>();
      data1.Add(1);
      data1.Add(2);
      data1.Add(3);
      Console.WriteLine("data1:");
      foreach(int item in data1) Console.WriteLine(item);

      List<int> data2 = new List<int>() { 1, 2, 3 };
      Console.WriteLine("\ndata2:");
      foreach (int item in data2) Console.WriteLine(item);
      Console.ReadKey();
    }
  }
}
