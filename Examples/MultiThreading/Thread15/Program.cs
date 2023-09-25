using System;
using System.Threading;

namespace Thread15 {
  class Program {
    static void Main(string[] args) {
      Thread t = new Thread(name=>{
        Console.WriteLine("Object {0} Thread ID#{1}",
        name,Thread.CurrentThread.ManagedThreadId);
      });
      Console.WriteLine("Thread Object created");
      t.Start("MyObject");
      Console.WriteLine("Main() is Ending...");
      Console.ReadKey();
    }
  }
}
