using System;
using System.Threading;
namespace Island {
  class X {
    String Name;
    public X Sibling;
    public X(String name) {
      Name = name;
    }
    ~X(){
      Console.WriteLine("{0} is destroyed",Name);
    }
  }
  class Program {
    static void Main(string[] args) {
      X a = new X("A");
      X b = new X("B");
      X c = new X("C");
      new X("D");//This immediately as garbage
      a.Sibling = b;
      b.Sibling = c;
      c.Sibling = a;
      a = null;
      b = null;
      //c = null;
      //Isolated Island formed at this point
      GC.Collect();
      Thread.Sleep(2000);
      Console.WriteLine("Main() done...");
      Console.ReadKey();
    }
  }
}
