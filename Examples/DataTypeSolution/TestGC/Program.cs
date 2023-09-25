using System;
using System.Runtime.Remoting.Lifetime;
using System.Threading;

namespace TestGC {
  class X:IDisposable{
    String Name;
    public X(String name) {
      Name = name;
      Console.WriteLine("{0} is created..", Name);
      Console.WriteLine("{0} is allocated resources.", Name);
    }
    public void Operation() {
      Console.WriteLine("{0} is comsuming resources.", Name);
    }
    public void Dispose() {
      Console.WriteLine("{0} is releasing resources..", Name);
      GC.SuppressFinalize(this);
    }
    ~X() {
      Dispose();
      Console.WriteLine("{0} is destroyed..", Name);
    }
  }
  class Program {
    static void Main(string[] args) {
      using (X x = new X("X")) {
        x.Operation();
      }
      Console.WriteLine("X is garbage now");
      for (int i = 0; i < 10; i++) {
        Console.Write("*");
        Thread.Sleep(1000);
      }
      GC.Collect();
      Thread.Sleep(2000);
      Console.WriteLine();
      Console.WriteLine("Main() done....");
      Console.ReadKey();
    }
  }
}
