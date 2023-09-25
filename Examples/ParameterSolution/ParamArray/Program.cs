using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParamArray {
  class Program {
    static double Sum(params double[] items) {
      double sum = 0;
      foreach (var item in items) sum += item;
      return sum;
    }
    static double Max(double max, params double[] items) {
      foreach (var item in items){
        if (max < item) max = item;
      }
      return max;
    }
    static bool isPrime(long n) {
      if (n<0) n = -n;
      int i;
      for (i = 2; (i < n)&&((n % i) != 0); i++);
      return (i == n);
    }

    static int CountPrimes(params long[] numbers) {
      int n = 0;
      foreach (var number in numbers) if (isPrime(number)) n++;
      return n;
    }


    static void Main(string[] args) {
      Console.WriteLine("The max value is {0}", Max(4, 3, 6, 2, 1, 5));
      Console.WriteLine("The max value is {0}", Max(4));
      Console.WriteLine("CountPrimes(4,1,-3,2,5,6,7,8,9) is {0}", 
        CountPrimes(4,1,-3,2,5,6,7,8,9));
      long[] data = { 4, 1, -3, 2, 5, 6, 7, 8, 9 };
      Console.WriteLine("CountPrimes(data) is {0}",CountPrimes(data));

      Console.ReadKey();
    }
    //static void Main(string[] args) {
    //  Console.WriteLine("Sum(1,2,3)={0}", Sum(1, 2, 3));
    //  Console.WriteLine("Sum(1,2,3,4,5)={0}", Sum(1, 2, 3, 4, 5));
    //  double[] data = { 1.1, 2.2, 3.3, 4.4 };
    //  Console.WriteLine("Sum(data)={0}", Sum(data));
    //  Console.WriteLine("Sum(data)={0}", Sum(1.1, 2.2, 3.3, 4.4));
    //  Console.ReadKey();
    //}
  }
}
