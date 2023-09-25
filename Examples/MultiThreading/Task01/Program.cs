using System;
using System.Threading.Tasks;

namespace Task01 {
  class Program {
    static void Main(string[] args) {
      Task.Factory.StartNew(()=>{
        Console.WriteLine("Hello world");
      });
      Console.ReadLine();
      Console.WriteLine("Main is ending...");
    }
  }
}
