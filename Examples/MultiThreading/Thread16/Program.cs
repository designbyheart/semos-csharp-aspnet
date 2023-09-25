using System;
using System.Threading;

namespace Thread16 {
  class Program {
    static void MyThread(){
      ulong counter=0;
      while(true){//Busy loop
        try{
          Console.WriteLine("counter={0}",counter++);
        }
        catch(ThreadAbortException ex){
          Console.WriteLine("Child thread aborted!");
        }
      }
    }
    static void Main(string[] args) {
      Thread t = new Thread(new ThreadStart(MyThread));
      Console.WriteLine("Thread Object created");
      t.Start();
      Thread.Sleep(2000);
      Console.ReadLine();
      t.Abort();
      Console.WriteLine("Main() is Ending...");
      Console.ReadKey();
    }
  }
}
