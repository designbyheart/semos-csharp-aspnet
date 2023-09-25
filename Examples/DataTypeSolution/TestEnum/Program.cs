using System;

namespace TestEnum {
  enum MONTH{JAN,FEB,MAR,APR,MAY,JUN,JUL,AUG,SEP,OCT,NOV,DEC};
  class Program {
    static void Main(string[] args) {
      MONTH month = MONTH.MAY;
      Console.WriteLine("month={0}", month);
      Console.WriteLine("month={0}", (int)month);
      Console.ReadKey();
    }
  }
}
