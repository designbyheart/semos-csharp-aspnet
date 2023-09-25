using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQIEnumerable {
  class Program {
    static IEnumerable<int> Filter(List<int> data) {
      foreach (int item in data) {
        if (item < 3) yield return item;
      }
    }
    static void Main(string[] args) {
      List<int> Data = new List<int>() { 1, 2, 3, 4, 5 };

      //IEnumerable<int> query = from item in Data
      //                          where item < 3
      //                          select item;

      IEnumerable<int> query = Filter(Data);


      //for (int i = 0; i < Data.Count; i++) Console.WriteLine(Data[i]);

      //foreach (int item in Data) Console.WriteLine(item);

      List<int>.Enumerator e = Data.GetEnumerator();
      while (e.MoveNext()) {
        Console.WriteLine(e.Current);
      }


      Console.ReadKey();
    }
  }
}
