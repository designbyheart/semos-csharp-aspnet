using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YieldReturn {
  class Program {
    static bool isPrime(int n) {
      int i;
      if (n < 0) n = -n;
      for (i = 2; i < n; i++) if ((n % i) == 0) break;
      return (i == n);
    }
    static IEnumerable<int> GetPrimes(int n) {
      for (int i = 1; i < n; i++) {
        if (isPrime(i)) {
          Console.Write("*");
          yield return i;
        }
      }
    }
    static List<int> GetPrimes2(int n) {
      var result = new List<int>();
      for (int i = 1; i < n; i++) {
        if (isPrime(i)) {
          Console.Write("*");
          result.Add(i);
        }
      }
      return result;
    }
    static void Main(string[] args) {
      foreach(int prime in GetPrimes(20)) {
        Console.WriteLine(prime);
      }
      Console.ReadKey();
    }
  }
}
