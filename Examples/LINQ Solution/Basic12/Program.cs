using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQDistinct {
  class Program {
    static void Main(string[] args) {
      int[] data = { 2, 4, 6, 1, 7, 9, 4, 8, 2, 3 };

      Console.WriteLine("--------- Small Data -----------");
      var smallData = from item in data
                      where item < 5
                      orderby item
                      select item;
      foreach (int item in smallData) Console.WriteLine(item);

      Console.WriteLine("----- Small Data (Distinct)-----");
      var smallDataDistinct = (from item in data
                              where item < 5
                              orderby item
                              select item).Distinct();
      foreach (int item in smallDataDistinct) Console.WriteLine(item);

      Console.ReadKey();
    }
  }
}
