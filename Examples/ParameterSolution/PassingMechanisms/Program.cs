using System;
using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace PassingMechanisms {
  class Program {
    static void Swap(ref int x, ref int y) {
      int temp=x;
      x = y;
      y = temp;
    }
    static void ModDiv(int x, int y, out int m, out int d){
      m = x % y;
      d = x / y;
    }
    static void Main(string[] args) {
      int x;
      int mod, div;

      ModDiv(22, 7, out mod, out div);
      Console.WriteLine("Mod is {0} and Div is {1}", mod, div);
      Console.ReadKey();
    }
    //static void Main(string[] args) {
    //  int x = 5, y = 7;
    //  Console.WriteLine("x={0}\ty={1}", x, y);
    //  Swap(ref x, ref y);
    //  Console.WriteLine("x={0}\ty={1}", x, y);
    //  Console.ReadKey();
    //}
  }
}
