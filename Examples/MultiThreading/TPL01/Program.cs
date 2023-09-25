using System;
using System.Threading.Tasks;

namespace TPL01 {
  class Program {
    public static void Main(string[] args){
      Parallel.For(0,10, index=>{
        Console.WriteLine("Task({0}) processing index:{1}",
	        Task.CurrentId, index);
      });
    }
  }
}