using System;
using System.Threading.Tasks;

namespace Synchronization02 {
  class Program {
    static void Main(string[] args) {
      int x=0;
      Parallel.For(0,10_000_000,i=>{
        x++;
        x--;
      });
      Console.WriteLine("x={0}",x);
      Console.ReadKey();
    }
  }
}