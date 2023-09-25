using System;
using System.IO;

namespace Ex03ReadToString {
  class Program {
    static void Main(string[] args) {
      StreamReader streamReader = new StreamReader(@"C:\test\new.txt");
      try {
        string text = streamReader.ReadToEnd();
        Console.WriteLine(text);
      }
      finally {
        streamReader.Close();
      }
      Console.WriteLine("DONE");
      Console.ReadKey();
    }
  }
}
