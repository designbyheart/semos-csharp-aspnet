using System;
using System.Threading;

namespace Timers {
  class Program {
    private static void TimerProc(Object state){
      Console.WriteLine("The current time is {0} on thread {1}",
          DateTime.Now, Thread.CurrentThread.ManagedThreadId);
      Thread.Sleep(3000);
    }
    static void Main(string[] args) {
      Console.WriteLine("Press <ENTER> when finished\n\n");
      Timer myTimer = new Timer(new TimerCallback(TimerProc), null,0,2000);
      Console.ReadLine();
      myTimer.Dispose();
    }
  }
}