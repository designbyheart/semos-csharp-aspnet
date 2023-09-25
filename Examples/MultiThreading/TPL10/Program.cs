using System;
using System.Threading.Tasks;

namespace TPL10 {
  class Program {
    static void Main(string[] args) {
      //invoke actions described by Lambda Expression
      Parallel.Invoke(
        ()=>Console.WriteLine("Action 1"),
        ()=>Console.WriteLine("Action 2"),
        ()=>Console.WriteLine("Action 3")
        );

      //Explicitly create an array of actions
      Action[] actions={
        ()=>Console.WriteLine("Action 4"),
        ()=>Console.WriteLine("Action 5"),
        ()=>Console.WriteLine("Action 6"),
      };
      Parallel.Invoke(actions);

      //Create the same effect using tasks explicitly
      Task parent = Task.Factory.StartNew(()=>{
        foreach(Action action in  actions){
          Task.Factory.StartNew(action, 
            TaskCreationOptions.AttachedToParent);
        }
      });

      //Wait for the task to finish
      parent.Wait();
      Console.ReadKey();
    }
  }
}
