using System;
using System.Threading;

namespace Synchronization07 {
  class Program {
    static int _Total=10000000;//int.MaxValue;
    [ThreadStatic]
    static double _Count = 0.01134;
    public static double Count{
      get { return _Count;}
      set{_Count = value;}
    }
    static void Main(string[] args) {
      Thread t = new Thread(()=>{
        Count = -Count;
        for(int i=0;i<_Total;i++) Count--;
        Console.WriteLine("Child thread's Count={0}",Count);
      });
      t.Start();
      for(int i=0;i<_Total;i++) Count++;
      t.Join();
      Console.WriteLine("Parent thread's Count={0}",Count);
      Console.ReadKey();
    }
  }
}