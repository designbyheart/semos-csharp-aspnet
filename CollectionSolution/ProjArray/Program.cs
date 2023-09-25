using System;

namespace ProjArray {
  class Program {
    static void Main(string[] args) {
      Console.Write("No of Items:>>");
      String[] items = new String[uint.Parse(Console.ReadLine())];
      for (int i = 0; i < items.Length; i++) {
        Console.Write("items[{0}]>>",i);
        items[i] = Console.ReadLine().Trim();
      }
      Console.WriteLine("--- The items you entered -----");
      foreach (String s in items) Console.WriteLine(s);
      Console.ReadKey();
    }
  }
}
