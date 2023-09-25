using System;
using System.Threading;

namespace Thread04 {
  class Program {
    static void MyThread(){
      Console.WriteLine("Thread ID#{0}",
        Thread.CurrentThread.ManagedThreadId);
    }
    static void Main(string[] args) {
      Thread t1 = new Thread(new ThreadStart(MyThread));
      Thread t2 = new Thread(new ThreadStart(MyThread));
      Console.WriteLine("Thread Object created");
      t1.Start();
      t2.Start();
      Console.WriteLine("Main() is Ending...");
      Console.ReadKey();
    }
  }
}
