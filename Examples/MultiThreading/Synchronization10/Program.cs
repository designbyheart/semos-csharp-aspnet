using System;
using System.Threading.Tasks;

namespace Synchronization10 {
  class BankAccount{
    public int Balance{get;set;} //Auto property
  }
  class Program {
    static void Main(string[] args) {
      BankAccount account = new BankAccount();

      Task[] tasks = new Task[100];

      //create the lock object
      object lockObj = new object();

      for(int i=0;i<100; i++){
        tasks[i] = new Task(()=>{
          for(int j=0;j<100000;j++){
            //lock(lockObj){
              account.Balance += 1;
            //}
          }
        });
        tasks[i].Start();
      }

      Task.WaitAll(tasks);

      Console.WriteLine("Expected Balance:10000000");
      Console.WriteLine("  Actual Balance:{0}",account.Balance);
      Console.ReadKey();
    }
  }
}
