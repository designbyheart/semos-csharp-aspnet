using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Ex01 {
  internal class Program {
    static bool isPrime(long n) {
      if (n < 0) n = -n;
      int i;
      for (i = 2; (i < n) && ((n % i) != 0); i++) ;
      return (i == n);
    }
    static void Main(string[] args) {
      Console.Write("n?>>");
      long n = long.Parse(Console.ReadLine());
      StringBuilder sb = new StringBuilder();
      uint i = 0;
      for(long p=0;p<n;p++) {
        if (isPrime(p)) {
          if (i > 0) sb.Append("\r\n");
          sb.Append(p);
          i++;
        }
      }
      try {
        File.WriteAllText(@"C:\test\primes.txt", sb.ToString());
      } catch (IOException ex) {
        Console.WriteLine("Error:{0}", ex.Message);
      }
      Console.WriteLine("DONE");
      Console.ReadKey();
    }
  }
}
