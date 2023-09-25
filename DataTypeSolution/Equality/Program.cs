using System;

namespace Equality {
  class X {
    int V;
    public X(int value) {
      V = value;
    }
    override public bool Equals(Object rhs) {
      return V == ((X)rhs).V;
    }
    static public bool operator==(X lhs, X rhs) {
      return lhs.V == rhs.V;
    }
    static public bool operator !=(X lhs, X rhs) {
      return lhs.V != rhs.V;
    }
  }
  class Program {
    static void Main(string[] args) {
      X a = new X(5);
      X b = new X(5);

      //Are the a and b references referring to the same object?
      Console.WriteLine("X.ReferenceEquals(a,b) is {0}", X.ReferenceEquals(a,b));//Always means Reference equality
      Console.WriteLine("a==b is {0}", (a == b));//Reference/Value equality

      //Are those objects referred by a and b having same value?
      Console.WriteLine("a.Equals(b) is {0}", a.Equals(b));//Value equality
      Console.ReadKey();
    }
  }
}
