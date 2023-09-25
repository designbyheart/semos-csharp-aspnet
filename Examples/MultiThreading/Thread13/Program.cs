using System;
using System.Threading;

namespace Thread13 {
  class Program {
    static void Main(string[] args) {
      Thread t = new Thread(()=>{//Lambda Expression
          Console.WriteLine("Thread ID#{0}",
            Thread.CurrentThread.ManagedThreadId);
        }
      );
      Console.WriteLine("Thread Object created");
      t.Start();
      Console.WriteLine("Main() is Ending...");
      Console.ReadKey();
    }
  }
}
