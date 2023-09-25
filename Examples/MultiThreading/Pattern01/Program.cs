//Asynchronous Delegate Invocation
using System;
using System.Threading;

namespace Pattern01 {
  class Program {
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
      Console.WriteLine("Application start");
      Console.WriteLine("Thread start");
      Func<long, long> workerMethod = LargestPrime; 
      IAsyncResult asynResult = workerMethod.BeginInvoke(1000,null,null);

      //Display periods while worker is running 
      while(!asynResult.AsyncWaitHandle.WaitOne(10,false)){
        Console.Write(".");
      }
      Console.WriteLine();
      Console.WriteLine("Thread end");
      Console.WriteLine(workerMethod.EndInvoke(asynResult));
      Console.WriteLine("Application end");
    }
  }
}