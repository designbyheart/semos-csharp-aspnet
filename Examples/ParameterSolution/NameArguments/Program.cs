using System;

namespace NameArguments {
  class Program {
    static double FV(double pv, float rate, uint terms) {
      for (uint i = 0; i < terms; i++) {
        pv *= (1.0 + rate);
      }
      return pv;
    }
    static double Pmt(double pv, float rate=0.05F/12, uint terms=30*12) {
      return pv *(rate*Math.Pow(1.0+rate,terms)/(Math.Pow(1.0+rate,terms)-1));
    }
    static void Main(string[] args) {

      Console.WriteLine("The monthly installment is {0:c}",
        Pmt(1_000_000, 0.046F/12, 20*12));
      Console.WriteLine("The monthly installment is {0:c}",
        Pmt(pv:1_000_000, rate:0.046F/12, terms:20*12));
      Console.WriteLine("The monthly installment is {0:c}",
        Pmt(rate: 0.046F/12, terms: 20*12, pv: 1_000_000));
      Console.WriteLine("The monthly installment is {0:c}",
        Pmt(pv:1_000_000));
      Console.WriteLine("The monthly installment is {0:c}",
        Pmt(pv:1_000_000,terms:25*12));
      Console.ReadKey();
    }
  }
}
