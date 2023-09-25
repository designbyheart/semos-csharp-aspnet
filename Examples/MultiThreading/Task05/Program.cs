using System;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Task05 {
  class Program {
    static void Main(string[] args) {
      bool parentTaskFaulted=false;
      Task task=Task.Factory.StartNew(()=>{
          throw new ApplicationException();
        }
      );

      Task faultedTask = task.ContinueWith(
          (parentTask)=>{
            parentTaskFaulted = parentTask.IsFaulted;
          }, TaskContinuationOptions.OnlyOnFaulted
        );
      faultedTask.Wait();
      Trace.Assert(parentTaskFaulted);
      if(!task.IsFaulted){
        task.Wait();
      }
      else{
        Console.WriteLine("ERROR: {0}", task.Exception.Message);
      }
    }
  }
}