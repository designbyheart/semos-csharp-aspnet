using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Task02 {
  class Program {
    static class Utility{
      static readonly string busySymbols=@"-\|/";
      public static IEnumerable<char> BusySymbols{
        get{
          int next=0;
          while(true){
            yield return busySymbols[next];
            next = (++next)%busySymbols.Length;
            yield return '\b';
          }
        }
      }
    }
    static bool isPrime(long v){
      long i;
      for(i=2;i<v;i++){
        Thread.Sleep(10);//Intentionally slow down
        if((v%i)==0) break;
      }
      return (i==v);
    }
    static long LargestPrime(long v){
      while(v>2){
        if (isPrime(v)) break;
        v--;
      }
      return v;
    }
    static void Main(string[] args) {
      Task<long> task = Task.Factory.StartNew<long>(
          ()=>LargestPrime(1000)
        );

      //Block until the task completes.
      foreach(char c in Utility.BusySymbols){
        if(task.IsCompleted) break;
        Console.Write(c);
      }

      Console.WriteLine("\nResult={0}",task.Result);
      System.Diagnostics.Trace.Assert(task.IsCompleted);
    }
  }
}