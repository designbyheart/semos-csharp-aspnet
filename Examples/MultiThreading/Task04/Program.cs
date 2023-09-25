using System;
using System.Threading.Tasks;

namespace Task04 {
  class Program {
    static void Main(string[] args) {
      Task task=Task.Factory.StartNew(()=>{
          throw new ApplicationException();
        }
      );
      try{
        task.Wait();
      }
      catch(AggregateException ex){
        foreach(Exception e in ex.InnerExceptions){
          Console.WriteLine("ERROR: {0}",e.Message);
        }
      }
    }
  }
}