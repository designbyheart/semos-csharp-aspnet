using System;
using System.Threading;
using System.Diagnostics;
/* --- Run this under non-debugging mode --- */
namespace ThreadPool2 {
  class Program {
    static void Main(string[] args) {
      const int N=1000;
      var evt=new CountdownEvent(N);

      //ThreadPool.SetMaxThreads(100,20);
      Console.WriteLine("Scheduling work...");
      var sw=new Stopwatch();
      sw.Start();
      for(int i=0;i<N;i++){
        ThreadPool.QueueUserWorkItem(_ =>
          {
            Thread.Sleep(100);
            Console.Write("X");
            evt.Signal();
          });
        Console.Write(".");
      }
      evt.Wait();
      sw.Stop();
      Console.WriteLine(sw.ElapsedMilliseconds);
      Console.ReadKey();
    }
  }
}