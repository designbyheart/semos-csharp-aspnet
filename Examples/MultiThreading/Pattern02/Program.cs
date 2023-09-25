//Background Worker Pattern
//Page:804 (Chapter 9, Essential C# 4.0 [0321694694]
using System;
using System.Threading;
using System.ComponentModel;
using System.Text;

namespace Pattern02 {
  class Program {
    public static BackgroundWorker calculationWorker=new BackgroundWorker();
    public static AutoResetEvent resetEvent=new AutoResetEvent(false);

    static void Main(string[] args) {
      int digitCount;
      Console.Write("Enter the number of digit to calculate:");
      if(int.TryParse(Console.ReadLine(), out digitCount)){
        Console.WriteLine("Enter to cancel");
        calculationWorker.DoWork += CalculatePI;
      }
      else{
        Console.WriteLine("The value entered is an invalid integer");
      }
    }
    private static void CalculatePI(object sender, DoWorkEventArgs eventArgs){
      int digits = (int)eventArgs.Argument;
      StringBuilder pi= new StringBuilder("3.", digits + 2);
      calculationWorker.ReportProgress(0,pi.ToString());

      //Calculate rest of pi, if required
      if(digits>0){
        for(int i=0;i<digits;i++){
          //Calculate next i decimal places
          //int nextDigit = PiDigitCalculator.
        }
      }
    }
  }
}
