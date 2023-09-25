using System;
using System.Threading;

namespace DisposableFramework {
  class X:IDisposable{
    public X() {
      Console.WriteLine("Allocated resource for X");
    }
    public void DoJob() {
      Console.WriteLine("Do job with the allocated resource");
    }

    public void Dispose() {
      Console.WriteLine("Deallocated resource from X");
      GC.SuppressFinalize(this);
    }

    ~X() {
      Dispose();
      Console.WriteLine("The object is destroyed");
    }
  }
  class Program {
    static void Main(string[] args) {
      using (X a = new X()) {
        a.DoJob();
      }
      Console.WriteLine("Now the object become garbage");
      for(int i = 0; i < 10; i++) {
        Console.Write('*');
        Thread.Sleep(1000);
      }
      GC.Collect();
      Thread.Sleep(2000);
      Console.WriteLine("main() ended");
      Console.ReadKey();
    }
  }
}
