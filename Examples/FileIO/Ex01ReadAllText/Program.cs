using System;
using System.IO;

namespace Ex01ReadAllText {
  class Program {
    static void Main(string[] args) {
      try {
        var text = File.ReadAllText(@"C:\test\new.txt");
        foreach (var s in text.Split('\n')) {
          Console.WriteLine(s);
        }

        File.WriteAllText(@"C:\test\new.txt", text + "\r\nDurian");
      }
      catch (IOException ex) {
        Console.WriteLine("Error:{0}", ex.Message);
      }
      Console.WriteLine("DONE");
      Console.ReadKey();
    }
  }
}
