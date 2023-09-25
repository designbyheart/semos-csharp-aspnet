//Using ReadWriteLockSlim class
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Synchronization08 {
  class Program {
    static void Main(string[] args) {
      ReaderWriterLockSlim rwlock = new ReaderWriterLockSlim();
      CancellationTokenSource tokenSource = new CancellationTokenSource();
      Task[] tasks = new Task[5];
      for(int i=0;i<tasks.Length; i++){
        tasks[i] = new Task(()=>{
          while(true){
            rwlock.EnterReadLock(); //Acquire the read lock
            Console.WriteLine("Read lock acquired - count:{0}",rwlock.CurrentReadCount);

            //wait - this simulates a read operation
            tokenSource.Token.WaitHandle.WaitOne(1000);

            rwlock.ExitReadLock(); //Release the read lock
            Console.WriteLine("Read lock released - count:{0}",rwlock.CurrentReadCount);

            //Check for cancellation
            tokenSource.Token.ThrowIfCancellationRequested();
          }
        }, tokenSource.Token);
        tasks[i].Start();
      }

      Console.WriteLine("Press <ENTER> to acquire write lock");
      Console.ReadLine();

      Console.WriteLine("Requesting write lock");
      rwlock.EnterWriteLock();
      Console.WriteLine("Write lock acquired");

      Console.WriteLine("Press <ENTER> to release write lock");
      Console.ReadLine();

      rwlock.ExitWriteLock();

      //wait for 5 second and cancel the tasks
      tokenSource.Token.WaitHandle.WaitOne(5000);
      tokenSource.Cancel();

      try{
        Task.WaitAll(tasks);
      }
      catch(AggregateException){
        //Do nothing...
      } 
      Console.WriteLine("Application end....");
      Console.ReadKey();
    }
  }
}
