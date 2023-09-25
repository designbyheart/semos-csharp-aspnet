using System;
using System.IO;

namespace Ex04GetFiles {
  class Program {
    static void Main(string[] args) {
      string[] files = Directory.GetFiles(@"c:\test", "*.txt",SearchOption.AllDirectories);
      foreach (string fn in files)
        Console.WriteLine(fn);
      Console.WriteLine("DONE");
      Console.ReadKey();
    }
  }
}
