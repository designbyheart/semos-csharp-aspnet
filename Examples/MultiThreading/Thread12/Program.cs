using System;
using System.Threading;

namespace Thread12 {
  class Program {
    static void Main(string[] args) {
      Thread t = new Thread(delegate() {//Anonymous Delegate
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
