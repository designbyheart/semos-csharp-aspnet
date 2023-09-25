using System;
using System.Threading;

namespace Thread01 {
  class Program {
    static void MyThread(){
      Console.WriteLine("Thread ID#{0}",
        Thread.CurrentThread.ManagedThreadId);
    }
    static void Main(string[] args) {
      Thread t = new Thread(new ThreadStart(MyThread));
      Console.WriteLine("Thread Object created");
      t.Start();
      Console.WriteLine("Main() is Ending...");
      Console.ReadKey();
    }
  }
}
