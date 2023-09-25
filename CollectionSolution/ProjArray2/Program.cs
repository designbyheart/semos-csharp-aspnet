using System;

namespace ProjArray2 {
  class Program {
    const uint BUFFER_SIZE = 5;
    static void Main(string[] args) {
      String[] items = new String[BUFFER_SIZE];
      uint n = 0;
      while (true) {
        Console.Write("items[{0}]>>", n);
        String s = Console.ReadLine().Trim();
        if (s == "") break;
        if (n == items.Length) {
          String[] items2 = new String[items.Length+BUFFER_SIZE];
          Array.Copy(items, items2, n);
          items = items2;
        }
        items[n++] = s;
      }
      Console.WriteLine("--- The items you entered -----");
      for(int i=0;i<n;i++) Console.WriteLine(items[i]);

      //Add new item to the front
      if (n == items.Length) {
        String[] items2 = new String[items.Length + BUFFER_SIZE];
        Array.Copy(items, items2, n);
        items = items2;
      }
      for (int i = 0; i < n; i++) {
        items[n - i] = items[n - 1 - i];
      }
      n++;
      items[0] = "Passion Fruit";
      Console.WriteLine("--- After add new item to the front  -----");
      for (int i = 0; i < n; i++) Console.WriteLine(items[i]);
      //Remove second item
      if(n>1){
        for (int i = 1; i < (n - 1); i++) {
          items[i] = items[i + 1];
        }
        items[--n] = null;
      }
      Console.WriteLine("--- After remove second item  -----");
      for (int i = 0; i < n; i++) Console.WriteLine(items[i]);
      Console.ReadKey();
    }
  }
}
