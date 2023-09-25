using System;
using System.Threading;

namespace Thread02 {
  class MyClass{
    String Name;
    public int Data;
    public MyClass(String name){
      Name = name;
    }
    public void MyThread(){
      Console.WriteLine("Object:{0} Data:{1} Thread ID#{2}",
        Name,Data,Thread.CurrentThread.ManagedThreadId);
    }
  }
  class Program {
    static void Main(string[] args) {
      MyClass mc = new MyClass("MyObj");
      mc.Data = 100;
      Thread t = new Thread(new ThreadStart(mc.MyThread));
      Console.WriteLine("Thread Object created");
      t.Start();
      Console.WriteLine("Main() is Ending...");
      Console.ReadKey();
    }
  }
}
