using System;
using System.Threading;
namespace DestructorChain {
  class X {
    public X() {
      Console.WriteLine("Allocated resources for X");
    }
    ~X() {
      Console.WriteLine("Deallocated resources from X");
    }
  }
  class Y:X {
    public Y():base() {
      Console.WriteLine("Allocated resources for Y");
    }
    ~Y() {
      Console.WriteLine("Deallocated resources from Y");
    }
  }
  class Program {
    static void Main(string[] args) {
      //X a = new X();
      Y b = new Y();
      //a = null;
      b = null;
      GC.Collect();
      Thread.Sleep(2000);
      Console.WriteLine("Main() done...");
      Console.ReadKey();
    }
  }
}
