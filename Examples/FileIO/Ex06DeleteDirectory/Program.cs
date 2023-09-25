using System;
using System.IO;

namespace Ex06DeleteDirectory {
  class Program {
    static void Main(string[] args) {
      try {
        Directory.Delete(@"c:\test",true);
      } catch (IOException ex) {
        Console.WriteLine("Error:{0}", ex.Message);
      }
      Console.WriteLine("DONE");
      Console.ReadKey();
    }
  }
}
