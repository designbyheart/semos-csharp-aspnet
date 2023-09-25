using System;

namespace Unicode {
  class Program {
    static void Main(string[] args) {
      String myName1 = "凌志光";
      char Surname = '\u51CC';//'凌';
      String myName2 = "\u51CC\u5FD7\u5149";
      Console.OutputEncoding = System.Text.Encoding.UTF8;
      Console.WriteLine(Surname);
      Console.WriteLine(myName1);
      Console.WriteLine(myName2);
      Console.ReadKey();
    }
  }
}
