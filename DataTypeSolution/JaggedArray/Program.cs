using System;

namespace JaggedArray {
  class Day {
  }
  enum Month{Jan,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec};
  class Program {
    static void Main(string[] args) {
      Console.Write("Year>>");
      uint year = uint.Parse(Console.ReadLine());

      //Construct Calender
      Day[][] Calender = new Day[12][];
      for (Month m = Month.Jan; m <= Month.Dec; m++) {
        int n;
        switch (m) {
          case Month.Jan:
          case Month.Mar:
          case Month.May:
          case Month.Jul:
          case Month.Aug:
          case Month.Oct:
          case Month.Dec:
            n = 31;
            break;
          case Month.Apr:
          case Month.Jun:
          case Month.Sep:
          case Month.Nov:
            n = 30;
            break;
          default://Feb
            n = IsLeapYear(year) ? 29 : 28;
            break;
        }
        Calender[(int)m] = new Day[n];
      }

      //Show Calender
      foreach (Month m in Enum.GetValues(typeof(Month))) {
        Console.Write("{0}:\t",m);
        foreach (Day d in Calender[(int)m]) Console.Write('D');
        Console.WriteLine();
      }
      Console.ReadKey();
    }
    static bool IsLeapYear(uint year) {
      if ((year%4)!=0) return false;
      if ((year%100)!=0) return true;
      if ((year%400)!=0) return false;
      return true;
    }
  }
}
