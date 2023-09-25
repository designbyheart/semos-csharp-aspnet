using System;
using System.Threading;
using System.Threading.Tasks;

namespace TPLSync {
  class Program {
    static readonly object myLock=new object();
    static void Greeting(){
      while(true){
        lock(myLock){
          Console.Write("{0}:Selamat ",Thread.CurrentThread.ManagedThreadId);
          Console.Write("Hari ");
          Console.WriteLine("Raya");
        }
      }
    }
    static void Main(string[] args) {
      Action[] tasks = {
                       Greeting,
                       Greeting,
                       Greeting,
                       Greeting,
                       Greeting,
                       Greeting,
                       Greeting,
                       Greeting,
                       Greeting,
                       Greeting,
                     };
      Parallel.Invoke(tasks);
    }
  }
}
