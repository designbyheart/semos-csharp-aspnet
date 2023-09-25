using System;
using System.IO;

namespace Ex05DeleteFiles {
  class Program {
    static void Main(string[] args) {
      string[] filePaths = Directory.GetFiles(@"c:\test");
      foreach (string path in filePaths) File.Delete(path);

      //Array.ForEach(Directory.GetFiles(@"c:\test\"), delegate(string path) { File.Delete(path); });
      Console.WriteLine("DONE");
      Console.ReadKey();
    }
  }
}
