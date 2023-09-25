using System;

namespace SingleCastDelegate {
  delegate int MathOp(int x, int y);
  class X {
    int A;
    public X(int a) { A = a; }
    public int InstOp(int x, int y) {
      return x + y + A;
    }
    public static int ClassOp(int x, int y) {
      return x * y - 1;
    }
  }
  class Program {
    static int Addition(int x, int y) { return x + y;}
    static int Subtraction(int x, int y) { return x - y; }
    static int Multiplication(int x, int y) { return x * y; }
    static int Division(int x, int y) { return x / y; }
    static int Modulus(int x, int y) { return x % y; }

    static void Main(string[] args) {
      MathOp op = new MathOp(Addition);
      Console.WriteLine("Op #1={0}", op(22, 7));
      op = new MathOp(Subtraction);
      Console.WriteLine("Op #2={0}", op(22, 7));
      op = Multiplication;
      Console.WriteLine("Op #3={0}", op(22, 7));
      Console.WriteLine("Op #4={0}", (new MathOp(Division))(22, 7));
      MathOp op2 = Modulus;
      op = op2;
      Console.WriteLine("Op #5={0}", op(22, 7));
      X x = new X(100);
      op = new MathOp(x.InstOp);
      Console.WriteLine("Op #6={0}", op(22, 7));
      op = new MathOp(X.ClassOp);
      Console.WriteLine("Op #7={0}", op(22, 7));
      Console.ReadKey();
    }
  }
}
