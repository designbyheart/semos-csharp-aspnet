using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task03 {
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
      Task<long> task = Task.Factory.StartNew<long>(
          ()=>LargestPrime(1000)
        );

      Task faultedTask = task.ContinueWith(
          (parentTask)=>{
            Trace.Assert(parentTask.IsFaulted);
            Console.WriteLine("Task State: Faulted");
          },TaskContinuationOptions.OnlyOnFaulted
        );

      Task canceledTask = task.ContinueWith(
          (parentTask)=>{
            Trace.Assert(parentTask.IsCanceled);
            Console.WriteLine("Task State: Canceled");
          },TaskContinuationOptions.OnlyOnCanceled
        );

      Task completedTask = task.ContinueWith(
          (parentTask)=>{
            Trace.Assert(parentTask.IsCompleted);
            Console.WriteLine("Task State: Completed with result:{0}", 
              parentTask.Result);
          },TaskContinuationOptions.OnlyOnRanToCompletion
        );
      
      completedTask.Wait();
      Console.WriteLine("Application end...");
    }
  }
}