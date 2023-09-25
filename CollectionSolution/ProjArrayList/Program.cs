using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjArrayList {
  class Program {
    static void Main(string[] args) {
      var items = new List<string>(1000);
      while (true) {
        Console.Write("items[{0}]>>", items.Count);
        String s = Console.ReadLine().Trim();
        if (s == "") break;
        items.Add(s);
      }
      //items.TrimToSize();//ArraList
      items.TrimExcess();  //List<>
      Console.WriteLine("--- The items you entered -----");
      for (int i = 0; i < items.Count; i++) Console.WriteLine(items[i]);

      //Add new item to the front
      items.Insert(0,"Passion Fruit");
      Console.WriteLine("--- After add new item to the front  -----");
      for (int i = 0; i < items.Count; i++) Console.WriteLine(items[i]);
      //Remove second item
      if (items.Count > 1) items.RemoveAt(1);
      Console.WriteLine("--- After remove second item  -----");
      for (int i = 0; i < items.Count; i++) Console.WriteLine(items[i]);
      string item = items[0];
      Console.ReadKey();
    }
  }
}
