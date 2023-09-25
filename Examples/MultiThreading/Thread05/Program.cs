using System;
using System.Threading;

namespace Thread05 {
  class Program {
    static void MyThread(Object COMPort){
      Console.WriteLine("COM Port#:{0} Thread ID#{1}",
        (int)COMPort, Thread.CurrentThread.ManagedThreadId);
    }
    static void Main(string[] args) {
      Thread t1 = new Thread(new ParameterizedThreadStart(MyThread));
      Thread t2 = new Thread(new ParameterizedThreadStart(MyThread));
      Console.WriteLine("Thread Object created");
      t1.Start(2);
      t2.Start(5);
      Console.WriteLine("Main() is Ending...");
      Console.ReadKey();
    }
  }
}
