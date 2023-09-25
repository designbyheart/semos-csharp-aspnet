using System;
using System.Threading;

namespace ThreadPool1 {
  class Program {
    static void Main(string[] args) {
      int nWT,nCPT;
      //ThreadPool.GetMaxThreads(out nWT,out nCPT);
      //Console.WriteLine("Max Available Thread={0}",nWT);
      //Console.WriteLine("Available Thread={0}",nWT);
      ThreadPool.GetAvailableThreads(out nWT,out nCPT);
      Console.WriteLine("Available Thread={0}",nWT);
      ThreadPool.QueueUserWorkItem(_ =>
        {
          Console.WriteLine("Work Item executed.");
        });
      ThreadPool.GetAvailableThreads(out nWT,out nCPT);
      Console.WriteLine("Available Thread={0}",nWT);
      Console.ReadLine();
      ThreadPool.GetAvailableThreads(out nWT,out nCPT);
      Console.WriteLine("Available Thread={0}",nWT);
      Console.ReadKey();
    }
  }
}