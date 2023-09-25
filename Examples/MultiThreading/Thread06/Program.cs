using System;
using System.Threading;

namespace Thread06 {
  class Program {
    static void MyThread(Object n){
      for(int i=0;i<(int)n;i++)
        Console.WriteLine("Thread ID#{0},i:{1}",
          Thread.CurrentThread.ManagedThreadId,i);
    }
    static void Main(string[] args) {
      Thread t1 = new Thread(new ParameterizedThreadStart(MyThread));
      Thread t2 = new Thread(new ParameterizedThreadStart(MyThread));
      Console.WriteLine("Thread Object created");
      t1.Start(100);
      t2.Start(150);
      Console.WriteLine("Main() is Ending...");
      Console.ReadKey();
    }
  }
}
