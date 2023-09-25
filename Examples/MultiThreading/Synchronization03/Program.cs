using System;
using System.Threading;

namespace Synchronization03 {
  class Program {
    readonly static object _Sync = new object();
    const int _Total = 10_000_000;
    static long _Count = 0;

    static void Main(string[] args) {
      Thread t = new Thread(()=>{
        for(int i=0;i<_Total;i++){
          bool lockTaken1=false;
          Monitor.Enter(_Sync, ref lockTaken1);
          try{
            _Count--;
          }
          finally{
            if(lockTaken1){
              Monitor.Exit(_Sync);
            }
          }
        }
      });
      t.Start();
      for(int i=0;i<_Total;i++){
        bool lockTaken2=false;
        Monitor.Enter(_Sync, ref lockTaken2);
        try{
          _Count++;
        }
        finally{
          if(lockTaken2){
            Monitor.Exit(_Sync);
          }
        }
      }
      t.Join();
      Console.WriteLine("Count={0}",_Count);
      Console.ReadKey();
    }
  }
}