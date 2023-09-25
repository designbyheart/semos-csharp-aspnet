using System;

namespace OperationOverloading {
  class Program {
    static double Sum(double x, double y) {
      return x + y;
    }
    static int Sum(int x, int y) {
      return x + y;
    }
    static int Sum(int x, int y, int z) {
      return x + y + z;
    }
    static double Sum(params double[] items) {
      double sum = 0;
      foreach (double item in items) sum += item;
      return sum;
    }

    static double Max(double max, params double[] items) {
      foreach (var item in items)
        if (max < item) max = item;
      return max;
    }

    static void Main(string[] args) {
      Console.WriteLine("Sum(1,3)={0}",Sum(1, 3));
      Console.WriteLine("Sum(1.1,3.3)={0}",Sum(1.1, 3.3));
      Console.WriteLine("Sum(1,3,5)={0}", Sum(1, 3.3, 5));
      Console.WriteLine("Sum(1,3,8,7,5,6)={0}", Sum(1, 3, 8, 7, 5, 6));
      Console.ReadKey();
    }
  }
}
