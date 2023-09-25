using System;
using System.Threading;

namespace Synchronization04 {
  class Program {
    readonly static object _Sync = new object();
    const int _Total = 100_000_000; //int.MaxValue;
    static long _Count = 0;

    static void Main(string[] args) {
      Thread t = new Thread(() => {
        for (int i = 0; i < _Total; i++) {
          lock (_Sync) {
            _Count--;
          }
        }
      });
      t.Start();
      for (int i = 0; i < _Total; i++) {
        lock (_Sync) {
          _Count++;
        }
      }
      t.Join();
      Console.WriteLine("Count={0}", _Count);
      Console.ReadKey();
    }
  }
}