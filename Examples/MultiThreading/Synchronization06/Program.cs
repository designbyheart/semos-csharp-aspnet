using System;
using System.Threading;

namespace Synchronization06 {
  class Program {
    static int _Total=10000000;//int.MaxValue;
    static ThreadLocal<double> _Count = new ThreadLocal<double>(()=>0.01134);
    public static double Count{
      get { return _Count.Value;}
      set{_Count.Value = value;}
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
      Console.WriteLine("Parent thread's Count={0}", Count);
      Console.ReadKey();
    }
  }
}