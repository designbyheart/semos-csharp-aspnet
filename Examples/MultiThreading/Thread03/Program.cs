using System;
using System.Threading;

namespace Thread03 {
  class Program {
    static void MyThread(Object name){
      Console.WriteLine("Object {0} Thread ID#{1}",
        name,Thread.CurrentThread.ManagedThreadId);
    }
    static void Main(string[] args) {
      Thread t = new Thread(new ParameterizedThreadStart(MyThread));
      Console.WriteLine("Thread Object created");
      t.Start("MyObject");
      Console.WriteLine("Main() is Ending...");
      Console.ReadKey();
    }
  }
}
