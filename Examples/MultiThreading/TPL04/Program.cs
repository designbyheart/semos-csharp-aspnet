using System;
using System.Threading;
using System.Threading.Tasks;

namespace TPL04 {
  class Program {
    static void Main(string[] args) {
      //Create ParallelOptions instance
      //and set the max concurrency to 1
      ParallelOptions options = 
        new ParallelOptions(){MaxDegreeOfParallelism=1};//try re-run with 2

      //Perform a parallel for loop
      Parallel.For(0,10,options, index=>{
        Console.WriteLine("For index({0}) started",index);
        Thread.Sleep(500);
        Console.WriteLine("For index({0}) finished",index);
      });

      //Create an array of ints to process
      int[] data={0,2,4,6,8};

      //Perform parallel foreach loop
      Parallel.ForEach(data, options,item=>{
        Console.WriteLine("Foreach item({0}) started",item);
        Thread.Sleep(500);
        Console.WriteLine("Foreach item({0}) finished",item);
      });
      Console.ReadKey();
    }
  }
}
