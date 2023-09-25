using System;
using System.Collections.Generic;

namespace ExDictionary {
  class Program {
    static void Main(string[] args) {
      Console.Write("Your input>>");
      string s = Console.ReadLine();
      var chars = new Dictionary<char, uint>();
      foreach(char c in s) {
        uint n = 1;
        if (chars.ContainsKey(c)) n += chars[c];
        chars[c] = n;
      }
      foreach(char c in chars.Keys) {
        Console.WriteLine("{0}:{1}",c,chars[c]);
      }
      Console.ReadKey();
    }
  }
}
