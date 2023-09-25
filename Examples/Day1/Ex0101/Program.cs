#define DEMO_FV
#define DEMO_Pmt

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0101 {
  internal class Program {
#if DEMO_Pmt
    
    static void Main(string[] args){
      double LoanAmount = 1_000_000;
      float YearlyRate = 0.046F;
      int DurationInYears = 30;
      //Financial f = new Financial();
      double MonthlyInstallment = Financial.Pmt(LoanAmount,YearlyRate/12,DurationInYears*12);
      Console.WriteLine("Monthly Installment:{0:c}", MonthlyInstallment);
      Console.WriteLine("Min Net Income:{0:c}", 3 *MonthlyInstallment);
      Console.WriteLine("Total Payment:{0:c}", MonthlyInstallment*DurationInYears*12);
      Console.ReadKey();
    }
    
#elif DEMO_FV
    static void Main(string[] args){
      double Saving = 100;
      float AnnualRate = 0.05F;
      //Financial f = new Financial();
      Console.WriteLine("Year FV");
      for(int year = 0; year <= 10; year++){
        Console.WriteLine("{0,-3} {1:c}",year,Financial.FV(Saving,AnnualRate,year));
      }
      Console.ReadKey();
    }
#else
    static void Main(string[] args) {
      Console.WriteLine("---1");
      //Console.WriteLine("The interest rate is {0}%", Account.InterestRate*100);
      Console.WriteLine("---2");
      Account acc1 = new Account(1000);
      Console.WriteLine("---3");
      Account acc2 = new Account();
      Console.WriteLine("---4");
      acc1.Withdraw(200);
      acc2.Deposit(100);
      acc1.Update();
      acc2.Update();
      Console.WriteLine("acc1.Balance is {0:c}", acc1.Balance);
      Console.WriteLine("acc2.Balance is {0:c}", acc2.Balance);
      Console.ReadKey();
    }
#endif
  }
}
