using System;
using System.Threading;

namespace Thread11 {
  class Program {
    static long N=0;
    static void MyThread(Object n){
      for(int i=0;i<(int)n;i++){
        N = N + 1;//1001
        //Console.WriteLine("Thread ID#{0},N:{1}",
        //  Thread.CurrentThread.ManagedThreadId,N);
      }
    }
    static void Main(string[] args) {
      Thread t1 = new Thread(new ParameterizedThreadStart(MyThread));
      Thread t2 = new Thread(new ParameterizedThreadStart(MyThread));
      Console.WriteLine("Thread Object created");
      t1.Start(1_000_000);
      t2.Start(1_000_000);
      t1.Join();
      t2.Join();
      Console.WriteLine("Main() is Ended with N={0}",N);
      Console.ReadKey();
    }
  }
}
