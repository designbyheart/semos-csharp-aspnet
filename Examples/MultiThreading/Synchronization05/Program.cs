using System;
using System.Threading;
using System.Reflection;

namespace Synchronization05 {
  class Program {
    static void Main(string[] args) {
      bool firstApplicationInstance;//Indicates whether this is the first application instance

      //Obtain the mutex name from the full assembly name
      string mutexName=Assembly.GetEntryAssembly().FullName;
      using(Mutex mutex=new Mutex(false, mutexName, out firstApplicationInstance)){
        if(!firstApplicationInstance){
          Console.WriteLine("This application is already running.");
        }
        Console.WriteLine("<ENTER> to shut down");
        Console.ReadLine();
      }
    }
  }
}