using System;
using System.Threading;

namespace Synchronization01 {
  class Program {
    const int _Total = 1_000_000; //int.MaxValue;
    static long _Count = 0;

    static void Main(string[] args) {
      Thread t = new Thread(()=>{
        for(int i=0;i<_Total;i++) _Count--;
      });
      t.Start();
      for(int i=0;i<_Total;i++) _Count++;;
      t.Join();
      Console.WriteLine("Count={0}",_Count);
      Console.ReadKey();
    }
  }
}