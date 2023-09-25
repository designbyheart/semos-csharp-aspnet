using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TPL03 {
  class Program {
    static IEnumerable<int> SteppedIterator(
        int startIndex, int endIndex, int stepSize){
      for(int i=startIndex;i<endIndex; i+= stepSize) yield return i;
    }
    public static void Main(string[] args){
      Parallel.ForEach(SteppedIterator(0,10,2), index=>{
        Console.WriteLine("Task({0}) processing index:{1}",
	        Task.CurrentId, index);
      });
      Console.ReadKey();
    }
  }
}