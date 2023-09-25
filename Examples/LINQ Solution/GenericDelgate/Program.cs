using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericDelegate {
  public delegate int MathOp1(int x, int y);
  public delegate double MathOp2(double x, double y);
  public delegate double MathOp3(long x, int y);

  public delegate TResult MathOperation<T1,T2,TResult>(T1 x, T2 y);

  class Program {
    static double Average(long a, long b) {
      return (double)(a + b) / 2;
    }
    static int Add(int x, int y) { return x + y; }

    static void Main(string[] args) {
      MathOperation<long,long,double> m1 = Average;
      Console.WriteLine("Average={0}",m1(7,10));

      MathOperation<int, int, int> m2 = Add;
      Console.WriteLine("Add={0}", m2(7, 10));

      Func<int, int, int> m3 = Add;
      Console.WriteLine("Add={0}", m3(7, 10));

      Func<long, long, double> m4 = Average;
      Console.WriteLine("Average={0}", m4(7, 10));
      Console.ReadKey();
    }
  }
}
