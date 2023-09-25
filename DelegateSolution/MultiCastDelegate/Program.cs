using System;

namespace MultiCastDelegate {
  delegate void Task(string doneByWho);

  class Program {
    static void TurnOffPCs(string who) {
      Console.WriteLine("{0} turn off all the PCs",who);
    }
    static void ShutDownServer(string who) {
      Console.WriteLine("{0} shut down the main server", who);
    }
    static void SwithOffLight(string who) {
      Console.WriteLine("{0} switch of the light in the lab", who);
    }
    static void Main(string[] args) {
      Task t = new Task(TurnOffPCs);
      t += new Task(ShutDownServer);
      t += SwithOffLight;
      t("Ali");
      t -= ShutDownServer;
      t("Abu");
      Console.ReadKey();
    }
  }
}
