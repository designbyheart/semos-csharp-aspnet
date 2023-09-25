using System;
using System.Threading;
using System.Diagnostics;
/* --- Run this under non-debugging mode --- */
namespace ThreadPool3 {
  class Program {
    static void Main(string[] args) {
      const int N=1000;
      var evt=new CountdownEvent(N);

      Console.WriteLine("Scheduling work...");
      var sw=new Stopwatch();
      sw.Start();
      for(int i=0;i<N;i++){
        new Thread(_ =>
          {
            Thread.Sleep(100);
            Console.Write("X");
            evt.Signal();
          }).Start();
        Console.Write(".");
      }
      evt.Wait();
      sw.Stop();
      Console.WriteLine(sw.ElapsedMilliseconds);
      Console.ReadKey();
    }
  }
}